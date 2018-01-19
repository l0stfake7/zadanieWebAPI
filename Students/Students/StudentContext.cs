using Microsoft.EntityFrameworkCore;
using Students.Models;

namespace Students
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Student> Students { get; set; }
    }
}