using HRMS.DataAccess.Abstractions;
using HRMS.DataAccess.Context;
using HRMS.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;


namespace HRMS.DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ADBContext _aDBContext;
        private readonly DbSet<T> _aDbSet;
        public GenericRepository(ADBContext context)
        {
            _aDBContext = context;
            _aDbSet = _aDBContext.Set<T>();
        }

    }
}
