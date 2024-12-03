using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Entities.Models
{
    public class PerformanceReviews
    {
        public DateTime ReviewDate { get; set; }
        public int Score { get; set; }
        public string Comments { get; set; }
    }
}
