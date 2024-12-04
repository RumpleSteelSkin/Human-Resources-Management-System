using HRMS.DataAccess.Context;
using HRMS.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DataAccess.Repositories
{
    public class LeaveRequestRepository(ADBContext context) : GenericRepository<Employee>(context)
    {
    }
}
