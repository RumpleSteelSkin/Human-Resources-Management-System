using HRMS.Entities.Abstractions;
namespace HRMS.Entities.Models
{
    public class PerformanceReview : BaseEntity
    {
        public DateTime ReviewDate { get; set; }
        public int Score { get; set; }
        public string? Comments { get; set; }

        //Navigation properties
        public Employee? Employee { get; set; } 
        public Guid EmployeeID { get; set; } 
        public Employee? Review { get; set; } 
        public Guid ReviewID { get; set; }

        public override string ToString()
        {
            return $"Puanlayan: {Review?.FullName} - Puanlanan: {Employee?.FullName} Puan: {Score} ";
        }
    }
}
