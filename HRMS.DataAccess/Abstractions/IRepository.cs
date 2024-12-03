using HRMS.Entities.Abstractions;

namespace HRMS.DataAccess.Abstractions
{
    public interface IRepository<T> where T : BaseEntity
    {
    }
}
