using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistence.Entities
{
    public class LeaveTypeConfiguration:IEntityTypeConfiguration<LeaveType>
    {
        public void Configure(EntityTypeBuilder<LeaveType> builder)
        {
            builder.HasData(
new LeaveType
{
    Id = 1,
    DefaultDays = 10,
    Name = "Vacation",
    CreatedBy = "Admin",    // Assuming default values are appropriate
    LastModifiedBy = "Admin" // Include this to satisfy the model requirements
},
new LeaveType
{
    Id = 2,
    DefaultDays = 12,
    Name = "Sick",
    CreatedBy = "Admin",
    LastModifiedBy = "Admin"
}
);


        }
    }
}
