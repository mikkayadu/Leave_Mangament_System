﻿using AutoMapper;
using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Application.Features.LeaveRequests.Requests.Queries;
using HR.LeaveManagement.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveRequests.Handlers.Queries
{
    
        public class GetLeaveRequestDetailRequestHandler : IRequestHandler<GetLeaveRequestDetailRequest, LeaveRequestDto>
        {
            private readonly ILeaveRequestRepository _leaveRequestRepository;
            private readonly IMapper _mapper;


            public GetLeaveRequestDetailRequestHandler(ILeaveRequestRepository leaveRequestRepository,
                IMapper mapper)

            {
                _leaveRequestRepository = leaveRequestRepository;
                _mapper = mapper;

            }
            public async Task<LeaveRequestDto> Handle(GetLeaveRequestDetailRequest request, CancellationToken cancellationToken)
            {
                var leaveRequest = _mapper.Map<LeaveRequestDto>(await _leaveRequestRepository.Get(request.Id));
                
                return leaveRequest;
            }
        }

    
}

