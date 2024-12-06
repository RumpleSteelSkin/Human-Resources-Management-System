using FluentValidation.Results;
using HRMS.Business.Validators;
using HRMS.DataAccess.Repositories;
using HRMS.Entities.Models;
using NTierArchitecture.Business.Abstractions;
using System.Linq.Expressions;

namespace HRMS.Business.Services
{
    public class EmployeeService(EmployeeRepository eRepo) : IManager<Employee>
    {
        private readonly EmployeeRepository _repository=eRepo;
        public void Create(Employee entity)
        {
            if (IfEntityExists(x => x.FirstName == entity.FirstName && x.LastName == entity.LastName && x.DateOfBirth == entity.DateOfBirth))
                throw new Exception($"{entity.FirstName} {entity.LastName} ismindeki çalışan daha önce kayıt edilmiştir.");
            ValidationResult result = new EmployeeValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join(",", result.Errors));
            _repository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var emp = _repository.GetById(id);
            if (emp != null && emp.IsActive)
                throw new Exception("Aktif olan bir çalışan silinemez.");
            _repository.DeleteById(id);
        }

        public IEnumerable<Employee>? GetAll()
        {
            return _repository.GetAll() ?? throw new Exception("çalışan kaydı  bulunmamaktadır.");
        }

        public Employee? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public bool IfEntityExists(Expression<Func<Employee, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(Employee entity)
        {
            ValidationResult result = new EmployeeValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join(",", result.Errors));
            if (entity != null)
                _repository.Update(entity);     
        }
    }
}
