using FluentValidation;
using HRMS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Business.Validators
{
    public class LeaveRequestValidator : AbstractValidator<LeaveRequest>
    {
        public LeaveRequestValidator() 
        {
            RuleFor(x => x.LeaveType)
                .NotEmpty().NotNull().WithMessage("Neden ayrılmak istediğinizi yazınız.");

            RuleFor(x => x.StartDate)
                .NotEmpty().NotNull().WithMessage("Lütfen başlama tarihini giriniz.")
                .GreaterThanOrEqualTo(DateTime.UtcNow).WithMessage("Başlangıç tarihi gelecek bir tarihte olamaz.");

            RuleFor(x => x.EndDate)
                .NotEmpty().NotNull().WithMessage("Bitiş tarihini belirtmek zorunludur.")
                .GreaterThanOrEqualTo(DateTime.UtcNow).WithMessage("Bitiş tarihi geçmiş bir tarihte olamaz.");

            RuleFor(x => x.LeaveStatus)
                .NotEmpty().NotNull().WithMessage("Neden ayrılacağınızı kısa bir cümle ile açıklayınız")
                .MaximumLength(50).WithMessage("Karakter sınırı aşıldı.!");

        }
    }
}
