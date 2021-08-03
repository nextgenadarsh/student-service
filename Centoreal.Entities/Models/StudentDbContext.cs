using Microsoft.EntityFrameworkCore;

namespace Centoreal.Entities.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}
