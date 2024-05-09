using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace HR.LeaveManagement.Application.Exceptions
{
    public class ValidationException:ApplicationException
    {
        public List<string> Errors {  get; set; } = new List<string>();

        public ValidationException(FluentValidation.Results.ValidationResult validationResult) {
            foreach (var error in validationResult.Errors)
            {
                Errors.Add(error.ErrorMessage);
            }
        }
    }
}
