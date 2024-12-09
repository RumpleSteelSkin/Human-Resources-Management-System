using HRMS.DataAccess.Repositories;
using HRMS.Entities.Models;
using NTierArchitecture.Business.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HRMS.Business.Services
{
    public class PerformanceReviewService : IManager<PerformanceReview>
    {
        private readonly PerformanceReviewRepository _repository;

        public PerformanceReviewService(PerformanceReviewRepository prRepo)
        {
            _repository = prRepo;
        }

       
        public void Create(PerformanceReview entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity), "Performans incelemesi boş olamaz");

            
            _repository.Create(entity);
        }

        public void Delete(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Geçersiz ID", nameof(id));

            var entity = _repository.GetById(id);
            if (entity == null)
                throw new InvalidOperationException("Performans incelemesi bulunamadı");

            _repository.DeleteById(id);
        }

        public IEnumerable<PerformanceReview>? GetAll()
        {
            return _repository.GetAll();
        }

        public PerformanceReview GetById(Guid id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException("Geçersiz ID", nameof(id));

            var entity = _repository.GetById(id);
            if (entity == null)
                throw new InvalidOperationException("Performans incelemesi bulunamadı");

            return entity;
        }

        public bool IfEntityExists(Expression<Func<PerformanceReview, bool>> filter)
        {
            if (filter == null)
                throw new ArgumentNullException(nameof(filter), "Filtre ifadesi null olamaz");

            return _repository.IfEntityExists(filter);
        }

        public void Update(PerformanceReview entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity), "Performans incelemesi null olamaz");

            var existingEntity = _repository.GetById(entity.ID);
            if (existingEntity == null)
                throw new InvalidOperationException("Performans incelemesi bulunamadı");
           
            _repository.Update(entity);
        }
    }
}
