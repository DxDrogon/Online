using Microsoft.EntityFrameworkCore;
using Online.Entities;

namespace Online.Context
{
    public class OnlineContext : DbContext
    {
        public OnlineContext(DbContextOptions<OnlineContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
