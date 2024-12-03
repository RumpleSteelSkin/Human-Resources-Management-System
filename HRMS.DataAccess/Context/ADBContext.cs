using Microsoft.EntityFrameworkCore;
using HRMS.Entities.Models;

namespace HRMS.DataAccess.Context
{
    public class ADBContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<PerformanceReview> PerformanceReviews { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<TrainingProgram> TrainingPrograms { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=HRMS;Integrated Security=True;Trust Server Certificate=True;User Id=Admin;Password=n^9Fu:,ek?$Wg01sU$I}6N9%)#JIQX8g");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PerformanceReview>()
                .HasOne(pr => pr.Employee)
                .WithMany()
                .HasForeignKey(pr => pr.EmployeeID)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<PerformanceReview>()
                .HasOne(pr => pr.Review)
                .WithMany()
                .HasForeignKey(pr => pr.ReviewID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
