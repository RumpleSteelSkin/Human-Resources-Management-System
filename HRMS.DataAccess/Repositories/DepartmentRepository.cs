﻿using HRMS.DataAccess.Context;
using HRMS.Entities.Models;

namespace HRMS.DataAccess.Repositories
{
    public class DepartmentRepository(ADBContext context) : GenericRepository<Department>(context)
    {
    }

}
