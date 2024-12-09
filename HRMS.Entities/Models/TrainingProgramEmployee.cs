namespace HRMS.Entities.Models
{
    public class TrainingProgramEmployee
    {
        //Navigation properties
        public Guid TrainingProgramID { get; set; }
        public TrainingProgram? TrainingProgram { get; set; }
        public Guid EmployeeID { get; set; }
        public Employee? Employee { get; set; }
    }
}
