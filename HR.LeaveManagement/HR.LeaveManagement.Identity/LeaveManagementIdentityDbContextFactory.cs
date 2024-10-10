using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Identity
{
    public class LeaveManagementIdentityDbContextFactory : IDesignTimeDbContextFactory<LeaveManagementIdentityDbContext>
    {
        public LeaveManagementIdentityDbContext CreateDbContext(string[] args)
        {
            var apiProjectPath = Path.Combine(Directory.GetCurrentDirectory(), "../HR.LeaveManagement.API");
            var configuration = new ConfigurationBuilder()
            .SetBasePath(apiProjectPath)
            .AddJsonFile("appsettings.json")
            .Build();

            var builder = new DbContextOptionsBuilder<LeaveManagementIdentityDbContext>();
            var connectionstring = configuration.GetConnectionString("LeaveManagementIdentityConnectionString");
            builder.UseNpgsql(connectionstring);

            return new LeaveManagementIdentityDbContext(builder.Options);
        }
    }
}
