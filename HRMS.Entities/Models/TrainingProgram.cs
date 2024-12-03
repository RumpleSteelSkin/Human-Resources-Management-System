using HRMS.Entities.Abstractions;
namespace HRMS.Entities.Models
{
    public class TrainingProgram : BaseEntity
    {
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Description { get; set; }

        //Navigation properties
        public Employee? Trainer { get; set; }
        public Guid TrainerID { get; set; }
        public ICollection<Employee>? Employees { get; set; } 
    }
}
