using HRMS.DataAccess.Context;
using HRMS.Entities.Models;

namespace HRMS.DataAccess.Repositories
{
    public class PerformanceReviewRepository(ADBContext context) : GenericRepository<PerformanceReview>(context)
    {
     
    }
}
