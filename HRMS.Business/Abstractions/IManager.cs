using HRMS.Entities.Abstractions;
using System.Linq.Expressions;
namespace NTierArchitecture.Business.Abstractions
{
    public interface IManager<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid id);
        T? GetById(Guid id);
        IEnumerable<T>? GetAll();
        bool IfEntityExists(Expression<Func<T, bool>> filter);
    }
}
