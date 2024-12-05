using FluentValidation.Results;
using HRMS.Business.Validators;
using HRMS.DataAccess.Repositories;
using HRMS.Entities.Models;
using NTierArchitecture.Business.Abstractions;
using System.Linq.Expressions;

namespace HRMS.Business.Services
{
    public class DepartmentService(DepartmentRepository dRepo) : IManager<Department>
    {
        private readonly DepartmentRepository _repository = dRepo;

        public void Create(Department entity)
        {
            if (IfEntityExists(x => x.Name == entity.Name))
                throw new Exception($"{entity.Name} isimli departman daha önce kayıt edilmiştir.");
            ValidationResult result = new DepartmentValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            _repository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var department = _repository.GetById(id);
            if (department != null && department.IsActive)
                throw new Exception("Aktif bir departman silinemez.");
            _repository.DeleteById(id);
        }

        public IEnumerable<Department>? GetAll()
        {
            return _repository.GetAll() ?? throw new Exception("Herhangi bir departman bulunamadı.");
        }

        public Department? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public bool IfEntityExists(Expression<Func<Department, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(Department entity)
        {
            ValidationResult result = new DepartmentValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            if (entity != null)
                _repository.Update(entity);
        }
    }
}
