﻿using FluentValidation;
using HRMS.Entities.Models;

namespace HRMS.Business.Validators
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.FullName)
              .NotNull().NotEmpty().WithMessage("Çalışan isim soyisim boş geçilemez.")
              .MinimumLength(3).WithMessage("Çalışanın isim soyisim minimum 3 karakter olmalıdır.");

            RuleFor(x => x.DateOfBirth)
                .NotNull().NotEmpty().WithMessage("Çalışanın doğum tarihi boş geçilemez.");

            RuleFor(x => x.Gender)
                .NotNull().NotEmpty().WithMessage("Çalışanın cinsiyeti boş geçilemez.");

            RuleFor(x => x.HireDate)
                .NotNull().NotEmpty().WithMessage("Çalışanın işe giriş tarihi girilmesi gerekmektedir.");

            RuleFor(x => x.Salary)
                .NotNull().NotEmpty().WithMessage("Çalışanın maaşı belirlenmelidir boş geçilemez.");
        }
    }
}
