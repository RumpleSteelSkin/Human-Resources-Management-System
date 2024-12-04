using HRMS.DataAccess.Context;
using HRMS.Entities.Models;
namespace HRMS.DataAccess.Repositories
{
    public class PositionRepository(ADBContext context) : GenericRepository <Position>(context)
    {
    }
}