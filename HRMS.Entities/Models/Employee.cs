using HRMS.Entities.Abstractions;
using System.Xml.Linq;
namespace HRMS.Entities.Models
{
    public class Employee : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName => $"{FirstName} {LastName}";
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? TerminationDate { get; set; } = null;
        public decimal Salary { get; set; }

        //Navigation properties
        public Department? Department { get; set; } 
        public Guid DepartmentID { get; set; }
        public Position? Position { get; set; } 
        public Guid PositionID { get; set; }
        public Guid? Subordinate { get; set; }
    }
}
