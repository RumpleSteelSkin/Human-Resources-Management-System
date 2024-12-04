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
            optionsBuilder.UseSqlServer(@"Data Source=AKARE;Initial Catalog=HRMS;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
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
