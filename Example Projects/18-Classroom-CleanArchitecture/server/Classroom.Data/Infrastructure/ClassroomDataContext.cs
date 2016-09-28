using Classroom.Core.Domain;
using System.Data.Entity;

namespace Classroom.Data.Infrastructure
{
    public class ClassroomDataContext : DbContext
    {
        public ClassroomDataContext() : base("Classroom")
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public IDbSet<Project> Projects { get; set; }
        public IDbSet<Assignment> Assignments { get; set; }
        public IDbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                        .HasMany(p => p.Assignments)
                        .WithRequired(a => a.Project)
                        .HasForeignKey(a => a.ProjectId);

            modelBuilder.Entity<Student>()
                        .HasMany(s => s.Assignments)
                        .WithRequired(a => a.Student)
                        .HasForeignKey(a => a.StudentId);

            modelBuilder.Entity<Assignment>()
                        .HasKey(a => new { a.StudentId, a.ProjectId });
        }
    }
}