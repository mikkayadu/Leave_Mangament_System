using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Identity.Configurations
{
    public class UserRoleConfiguration:IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1d30546b-c7e5-4a43-be1a-eb2e88f09f82",
                    UserId = "8ef76378-681a-4044-97ed-428612217206"
                },

                new IdentityUserRole<string>
                {
                    RoleId = "b760fe05-a63f-43d0-9267-5a46c95e6ded",
                    UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9"
                }
                );
        }
    }
}
