using FluentValidation.Results;
using HRMS.Business.Validators;
using HRMS.DataAccess.Repositories;
using HRMS.Entities.Models;
using NTierArchitecture.Business.Abstractions;
using System.Linq.Expressions;

namespace HRMS.Business.Services
{
    public class PositionService(PositionRepository pRepo) : IManager<Position>
    {
        private readonly PositionRepository _repository = pRepo;

        public void Create(Position entity)
        {
            if (IfEntityExists(x => x.Name == entity.Name))
                throw new Exception($"{entity.Name} isimli pozisyon zaten mevcut.");
            ValidationResult result = new PositionValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            _repository.Create(entity);
        }

        public void Delete(Guid id)
        {
            var position = _repository.GetById(id);
            if (position != null && position.IsActive)
                throw new Exception("Aktif bir pozisyon silinemez.");
            _repository.DeleteById(id);
        }

        public IEnumerable<Position>? GetAll()
        {
            return _repository.GetAll() ?? throw new Exception("Herhangi bir pozisyon bulunamadı.");
        }

        public Position? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public bool IfEntityExists(Expression<Func<Position, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(Position entity)
        {
            ValidationResult result = new PositionValidator().Validate(entity);
            if (!result.IsValid)
                throw new Exception(string.Join("\n", result.Errors));
            if (entity != null)
                _repository.Update(entity);
        }
    }
}
