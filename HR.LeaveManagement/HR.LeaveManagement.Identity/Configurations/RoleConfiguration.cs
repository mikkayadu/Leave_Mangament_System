using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.LeaveManagement.Identity.Configurations
{
    public class RoleConfiguration:IEntityTypeConfiguration<IdentityRole>
    {

        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "b760fe05-a63f-43d0-9267-5a46c95e6ded",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                },

                new IdentityRole
                {
                    Id = "1d30546b-c7e5-4a43-be1a-eb2e88f09f82",
                    Name = "Administrator",
                    NormalizedName = "Administrator".ToUpper()
                }
        );
        }
    }
}
