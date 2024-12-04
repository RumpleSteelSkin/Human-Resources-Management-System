using HRMS.Entities.Abstractions;
using System.Linq.Expressions;

namespace HRMS.DataAccess.Abstractions
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void DeleteById(Guid id);
        T? GetById(Guid id);
        IEnumerable<T>? GetAll();
        bool IfEntityExists(Expression<Func<T, bool>> filter);
    }
}
