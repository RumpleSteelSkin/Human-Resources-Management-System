using HRMS.DataAccess.Repositories;
using HRMS.Entities.Models;
using NTierArchitecture.Business.Abstractions;
using System.Linq.Expressions;

namespace HRMS.Business.Services
{
    public class TrainingProgramEmployeeService/*(TrainingProgramEmployeeRepository tpeRepo) : IManager<TrainingProgramEmployee>
    {
        private readonly TrainingProgramEmployeeRepository _repository = tpeRepo;
        public void Create(TrainingProgramEmployee entity)
        {
            _repository.Create(entity);
        }

        public void Delete(Guid id)
        {
            _repository.DeleteById(id);
        }

        public IEnumerable<TrainingProgramEmployee>? GetAll()
        {
            return _repository.GetAll();
        }

        public TrainingProgramEmployee? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public bool IfEntityExists(Expression<Func<TrainingProgramEmployee, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(TrainingProgramEmployee entity)
        {
            _repository.Update(entity);
        }*/
    { 
    }
}
