using HRMS.DataAccess.Context;
using HRMS.Entities.Models;

namespace HRMS.DataAccess.Repositories
{
    public class TrainingProgramRepository(ADBContext context) : GenericRepository<TrainingProgram>(context)
    {
    }
}
