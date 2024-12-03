using HRMS.Entities.Abstractions;
namespace HRMS.Entities.Models
{
    public class Department : BaseEntity
    {
        public string? Name { get; set; }
        public string? Location { get; set; }

    }
}
