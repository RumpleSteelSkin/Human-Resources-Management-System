using HRMS.DataAccess.Abstractions;
using HRMS.DataAccess.Context;
using HRMS.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
namespace HRMS.DataAccess.Repositories
{
    public class GenericRepository<T>(ADBContext context) : IRepository<T> where T : BaseEntity
    {
        protected readonly ADBContext? _context = context;
        private readonly DbSet<T> _dbSet = context.Set<T>();
        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _context?.SaveChanges();
        }

        public void DeleteById(Guid id)
        {
            _dbSet.Remove(GetById(id)!);
            _context?.SaveChanges();
        }

        public IEnumerable<T>? GetAll()
        {
            return [.. _dbSet];
        }

        public T? GetById(Guid id)
        {
            return _dbSet.Find(id) ?? throw new Exception($"ID '{id}' ile eşleşen kayıt bulunamadı.");
        }

        public bool IfEntityExists(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Any(filter);
        }

        public void Update(T entity)
        {
            _context?.SaveChanges();
        }
    }

}
