using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        public DbSet<Animal> Animals { get; set; }
    
            protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
              .HasData(
                  new Animal { AnimalId = 1, Name = "Rex", Species = "Dog", Age = 7, Gender = "Male" },
                  new Animal { AnimalId = 2, Name = "Sam", Species = "Cat", Age = 3, Gender = "Female" },
                  new Animal { AnimalId = 3, Name = "Luke", Species = "Dog", Age = 2, Gender = "Male" },
                  new Animal { AnimalId = 4, Name = "Charlie", Species = "Cat", Age = 4, Gender = "Male" },
                  new Animal { AnimalId = 5, Name = "Scout", Species = "Dog", Age = 8, Gender = "Female" }
              );
        }
    
    }
}
    