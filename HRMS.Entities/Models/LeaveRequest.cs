using HRMS.Entities.Abstractions;

namespace HRMS.Entities.Models
{
    public class LeaveRequest : BaseEntity
    {
        public string? LeaveType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? LeaveStatus { get; set; }

        //Navigation properties
        public Employee? Employee { get; set; }
        public Guid EmployeeID { get; set; }

        public override string ToString()
        {
            return $"{ID} {LeaveType} {LeaveStatus}";
        }
    }
}
