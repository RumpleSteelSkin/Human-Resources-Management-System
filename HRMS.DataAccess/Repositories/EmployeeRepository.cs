using HRMS.DataAccess.Context;
using HRMS.Entities.Models;

namespace HRMS.DataAccess.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>
    {
        public EmployeeRepository(ADBContext context) : base(context)
        {

        }
    }
}
