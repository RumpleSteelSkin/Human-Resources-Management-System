using FluentValidation;
using HRMS.Entities.Models;

namespace HRMS.Business.Validators
{
    public class PerformanceReviewValidator : AbstractValidator<PerformanceReview>
    {
        public PerformanceReviewValidator() 
        { 
            RuleFor(x => x.ReviewDate)
                .NotEmpty().WithMessage("İnceleme tarihini lütfen boş geçmeyiniz.");

            RuleFor(x => x.Score)
                .NotEmpty().WithMessage("Performans puanını giriniz.");

            RuleFor(x => x.Comments)
                .Length(100).WithMessage("Yorum ekleyebilirsiniz.");
        }
    }
}
