using FluentValidation;
using HRMS.Entities.Models;

namespace HRMS.Business.Validators
{
    public class DepartmentValidator : AbstractValidator<Department>
    {
        public DepartmentValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().NotEmpty().WithMessage("Departman adı boş geçilemez.")
                .MinimumLength(3).WithMessage("Departman adı en az 3 karakter olmalıdır.");

            RuleFor(x => x.Location)
                .NotNull().NotEmpty().WithMessage("Departman lokasyonu boş geçilemez.");
        }
    }
}
