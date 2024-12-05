using FluentValidation;
using HRMS.Entities.Models;

namespace HRMS.Business.Validators
{
    public class PositionValidator : AbstractValidator<Position>
    {
        public PositionValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().NotEmpty().WithMessage("Pozisyon adı boş geçilemez.")
                .MinimumLength(3).WithMessage("Pozisyon adı en az 3 karakter olmalıdır.");

            RuleFor(x => x.Salary)
                .NotNull().NotEmpty().WithMessage("Pozisyon başlangıç maaşı boş bırakılamaz.")
                .GreaterThan(0).WithMessage("Pozisyon başlangıç maaşı 0'dan büyük olmalıdır.");
        }
    }
}
