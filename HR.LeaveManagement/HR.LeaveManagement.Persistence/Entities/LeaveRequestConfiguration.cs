using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Persistence.Configurations.Entities
{
    public class LeaveRequestConfiguration : IEntityTypeConfiguration<LeaveRequest>
    {
        public void Configure(EntityTypeBuilder<LeaveRequest> builder)
        {
            builder.HasData(
                new LeaveRequest
                {
                    Id = 1,
                    StartDate = new DateTime(2024, 5, 25, 0, 0, 0, DateTimeKind.Utc),

                    EndDate = new DateTime(2024, 5, 31, 0, 0, 0, DateTimeKind.Utc),
                    LeaveTypeId = 1,
                    RequestComments = "Very urgent",
                    CreatedBy = "Admin",
                    LastModifiedBy = "Admin",
                    RequestingEmployeeId = "1",
                    
                    DateRequested = DateTime.UtcNow,
                    //DateActioned = DateTime.Now.AddDays(1),
                    //Approved = True

                    Cancelled = false,


                }) ;



        }
    }
}