using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTOs.LeaveType.Validators
{
    public class ILeaveTypeDtoValidator : AbstractValidator<ILeaveTypeDto>
    {
        public ILeaveTypeDtoValidator()
        {
            RuleFor(p => p.Name)
                        .NotEmpty().WithMessage("{PropertyName} is required.")
                        .NotNull()
                    .MaximumLength(50).WithMessage("{PropertyName} is required");

            RuleFor(p => p.DefaultDays)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(0).WithMessage("{PropertyName} should be greater than 0")
                .LessThan(100).WithMessage("{PropertyName} should be less than {ComparisonValue}.");
        }
    }
}
