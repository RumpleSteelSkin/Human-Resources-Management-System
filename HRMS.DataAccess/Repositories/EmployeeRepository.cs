﻿using HRMS.DataAccess.Context;
using HRMS.Entities.Models;

namespace HRMS.DataAccess.Repositories
{
    public class EmployeeRepository(ADBContext context) : GenericRepository<Employee>(context)
    {
    }
}
