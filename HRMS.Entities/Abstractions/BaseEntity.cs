namespace HRMS.Entities.Abstractions
{
    public abstract class BaseEntity
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
