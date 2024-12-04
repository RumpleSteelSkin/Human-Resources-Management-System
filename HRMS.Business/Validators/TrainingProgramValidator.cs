using FluentValidation;
using HRMS.Entities.Models;

namespace HRMS.Business.Validators
{
    public class TrainingProgramValidator:AbstractValidator<TrainingProgram>
    {
        public TrainingProgramValidator()
        {
            RuleFor(x => x.Name)
               .NotNull().NotEmpty().WithMessage("Eğitim programının ismi boş geçilemez.")
               .MinimumLength(5).WithMessage("Eğitim programının ismi minimum 5 karakter olmalıdır.");

            RuleFor(x => x.Trainer)
                .NotNull().NotEmpty().WithMessage("Eğitim programının çalışanlar arasından eğiticisini seçiniz.");

            RuleFor(x => x.StartDate)
                .NotNull().NotEmpty().WithMessage("Eğitim programı başlangıç tarihi girilmesi gerekmektedir.")
                .GreaterThanOrEqualTo(DateTime.Now).WithMessage("Eğitim programı geçmiş bir tarihte olamaz.");

            RuleFor(x => x.EndDate)
                .NotNull().NotEmpty().WithMessage("Eğitim programı bitiş tarihi girilmesi gerekmektedir.")
                .GreaterThanOrEqualTo(DateTime.Now).WithMessage("Eğitim programı geçmiş bir tarihte olamaz.");
        }
    }
}
