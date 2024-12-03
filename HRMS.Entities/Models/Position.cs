using HRMS.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Entities.Models
{
    public class Position : BaseEntity
    {
        public int PositionID { get; set; }
        public string? PositionName { get; set; }
        public decimal PositionsBaseSalary { get; set; }

    }
}
