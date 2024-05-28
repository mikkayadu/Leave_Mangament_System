using AutoMapper;
using HR.LeaveManagement.Application.Profiles;
using HR.LeaveManagement.MVC;
using Xunit;
namespace HR.LeaveManagement.Application.UnitTests
{
    public class AutoMapperProfileTests
    {
        private readonly IMapper _mapper;

        public AutoMapperProfileTests()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<HR.LeaveManagement.Application.Profiles.MappingProfile>(); // Add your AutoMapper profile here
            });

            _mapper = config.CreateMapper();
        }

        [Fact]
        public void AutoMapper_Configuration_IsValid()
        {
            var config = _mapper.ConfigurationProvider;
            config.AssertConfigurationIsValid(); // This will throw an exception if the configuration is invalid
        }
    }
}