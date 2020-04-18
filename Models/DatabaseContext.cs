using System;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CapstoneProject.Models
{
  public partial class DatabaseContext : DbContext
  {

    public DbSet<User> Users { get; set; }
    public DbSet<Animal> Animals { get; set; }
    public DbSet<Match> Matches { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 1,
            Name = "Jack",
            Age = "4 years old",
            CatOrDog = "Dog",
            Breed = "Greyhound",
            RescueCenter = "Greyhounds of Florida",
            Zipcode = "33713",
            HousingType = "house",
            NeedYard = true,
            GoodWithOtherAnimals = true,
            GoodWithSmallChildren = true,
            IsActive = true,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "Jack is a retired race dog who wants to spend the rest of his days with a family who will love and care for him. He would do best in a home that has a fenced yard.",
            ImageUrl = "../images/greyhound.jpg",
            DateAdded = DateTime.Now,
          }
      );

      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 2,
            Name = "Honey",
            Age = "6 years old",
            CatOrDog = "Cat",
            Breed = "Tabby",
            RescueCenter = "PetPal Animal Shelter",
            Zipcode = "33713",
            HousingType = "house",
            NeedYard = false,
            GoodWithOtherAnimals = true,
            GoodWithSmallChildren = true,
            IsActive = false,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "Honey is a sweet girl who is looking for someone with a comfy lap and has time to pet her for days.",
            ImageUrl = "../images/tabby.jpg",
            DateAdded = DateTime.Now,
          }
      );
    }



    private string ConvertPostConnectionToConnectionString(string connection)
    {
      var _connection = connection.Replace("postgres://", String.Empty);
      var output = Regex.Split(_connection, ":|@|/");
      return $"server={output[2]};database={output[4]};User Id={output[0]}; password={output[1]}; port={output[3]}";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        var envConn = Environment.GetEnvironmentVariable("DATABASE_URL");
        var conn = "server=localhost;database=CapstoneProjectDatabase";
        if (envConn != null)
        {
          conn = ConvertPostConnectionToConnectionString(envConn);
        }
        optionsBuilder.UseNpgsql(conn);
      }
    }

  }
}
