using FluentValidation.Results;
using HRMS.Business.Validators;
using HRMS.DataAccess.Repositories;
using HRMS.Entities.Models;
using NTierArchitecture.Business.Abstractions;
using System.Linq.Expressions;

namespace HRMS.Business.Services
{
    public class TrainingProgramService(TrainingProgramRepository tpRepo) : IManager<TrainingProgram>
    {
        private readonly TrainingProgramRepository _repository = tpRepo;
        public void Create(TrainingProgram entity)
        {
            if (IfEntityExists(x => x.Name == entity.Name))
                throw new Exception($"{entity.Name} ismindeki eğitim programı daha önce kayıt edilmiştir.");
            ValidationResult result = new TrainingProgramValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            _repository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var cat = _repository.GetById(id);
            if (cat != null && cat.IsActive)
                throw new Exception("Aktif olan bir eğitim programı silinemez.");
            _repository.DeleteById(id);
        }

        public IEnumerable<TrainingProgram>? GetAll()
        {
            return _repository.GetAll() ?? throw new Exception("Eğitim programı bulunmamaktadır.");
        }

        public TrainingProgram? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public bool IfEntityExists(Expression<Func<TrainingProgram, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(TrainingProgram entity)
        {
            ValidationResult result = new TrainingProgramValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            if (entity != null)
                _repository.Update(entity);
        }
    }
}
