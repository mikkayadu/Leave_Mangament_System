using AutoMapper;
using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Application.DTOs.LeaveType;
using HR.LeaveManagement.Application.Exceptions;
using HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Commands;
using HR.LeaveManagement.Application.Features.LeaveTypes.Handlers.Queries;
using HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Commands;
using HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries;
using HR.LeaveManagement.Application.Profiles;
using HR.LeaveManagement.Application.Reponses;
using HR.LeaveManagement.Application.UnitTests.Mocks;
using HR.LeaveManagement.Domain;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace HR.LeaveManagement.Application.UnitTests.LeaveTypes.Commands
{
    public class CreateLeaveTypeCommandHandlerTests
    {
        private readonly Mock<ILeaveTypeRepository> _mockLeaveTypeRepository;
        private readonly IMapper _mapper;
        private readonly CreateLeaveTypeCommandHandler _handler;
        private readonly CreateLeaveTypeDto _leaveTypeDto;

        public CreateLeaveTypeCommandHandlerTests()
        {
            _mockLeaveTypeRepository = new Mock<ILeaveTypeRepository>();
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();
            _handler = new CreateLeaveTypeCommandHandler(_mockLeaveTypeRepository.Object, _mapper);

            _leaveTypeDto = new CreateLeaveTypeDto
            {
                DefaultDays = 15,
                Name = "Test DTO",
                CreatedBy="Admin",
                LastModifiedBy = "Admin"
            };
        }

        [Fact]
        public async Task Handle_ValidLeaveType_AddedToRepository()
        {
            var command = new CreateLeaveTypeCommand { LeaveTypeDto = _leaveTypeDto };
            _mockLeaveTypeRepository.Setup(repo => repo.Add(It.IsAny<LeaveType>())).ReturnsAsync(new LeaveType());
            var result = await _handler.Handle(command, CancellationToken.None);
            result.ShouldNotBeNull();
            result.Success.ShouldBeTrue();
            result.Message.ShouldBe("Creation Successful");
            _mockLeaveTypeRepository.Verify(x =>
            x.Add(It.IsAny<LeaveType>()), Times.Once);

        }

        [Fact]
        public async Task Handle_InvalidLeaveType_ThrowsValidationException()
        {
            // Arrange
            var invalidDto = new CreateLeaveTypeDto { DefaultDays = 0, Name = "" }; // Invalid data
            var command = new CreateLeaveTypeCommand { LeaveTypeDto = invalidDto };

            // Act & Assert
            await Should.ThrowAsync<ValidationException>(() => _handler.Handle(command, CancellationToken.None));
            _mockLeaveTypeRepository.Verify(x => x.Add(It.IsAny<LeaveType>()), Times.Never);
        }
    }

    
        
    }
