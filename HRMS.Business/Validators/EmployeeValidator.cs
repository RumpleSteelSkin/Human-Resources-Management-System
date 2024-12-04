using FluentValidation;
using HRMS.Entities.Models;

namespace HRMS.Business.Validators
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            
        }
    }
}
