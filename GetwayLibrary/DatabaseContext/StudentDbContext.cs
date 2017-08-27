using Core.Library;
using System.Data.Entity;

namespace GetwayLibrary.DatabaseContext
{
    class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
