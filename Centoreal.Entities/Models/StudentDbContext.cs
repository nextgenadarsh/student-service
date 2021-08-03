using Microsoft.EntityFrameworkCore;

namespace Centoreal.Entities.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data Seeding
            modelBuilder.Entity<Address>().HasData(
                new Address { Id = 1, AddressLine = "Professor Colony", City = "Hyderabad", State = "Telangana", Country = "India" },
                new Address { Id = 2, AddressLine = "Kankarbagh", City = "Patna", State = "Bihar", Country = "India" },
                new Address { Id = 3, AddressLine = "Saket Colony", City = "Delhi", State = "Delhi", Country = "India" },
                new Address { Id = 4, AddressLine = "Dream Palace", City = "Himachal", State = "Uttarakhand", Country = "India" }
            );
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, AddressId = 1, Name = "Amit Bhadra" },
                new Student { Id = 2, AddressId = 2, Name = "Suresh Roy" },
                new Student { Id = 3, AddressId = 3, Name = "Kranti Raina" },
                new Student { Id = 4, AddressId = 4, Name = "Angelina Singh" }
            );
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }
}
