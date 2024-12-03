using HRMS.Entities.Abstractions;
namespace HRMS.Entities.Models
{
    public class Employee : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? TerminationDate { get; set; } = null;
        public decimal Salary { get; set; }


    }
}
