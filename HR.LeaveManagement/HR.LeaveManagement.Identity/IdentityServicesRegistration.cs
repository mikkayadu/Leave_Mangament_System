using HR.LeaveManagement.Application.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Identity
{
    public static class IdentityServicesRegistration
    {
        public  static IServiceCollection ConfigureIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
           services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));
            services.AddDbContext<LeaveManagementIdentityDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("LeaveManagementIdentityConnectionString"),
            b=>b.Migration));
        }
    }
}
