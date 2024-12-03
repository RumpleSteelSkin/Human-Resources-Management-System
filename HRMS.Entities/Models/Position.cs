using HRMS.Entities.Abstractions;
namespace HRMS.Entities.Models
{
    public class Position : BaseEntity
    {
        public string? Name { get; set; }
        public decimal Salary { get; set; }

    }
}
