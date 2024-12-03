using HRMS.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Entities.Models
{
    public class Department : BaseEntity
    {
        public int DepartmentID { get; set; }
        public string? DepartmentName { get; set; }
        public string? DepartmentLocation { get; set; }

    }
}
