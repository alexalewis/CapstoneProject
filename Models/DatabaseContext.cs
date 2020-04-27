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
    public DbSet<Favorite> Favorites { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 1,
            Name = "Jack",
            Age = "4 years old",
            Gender = "Male",
            CatOrDog = "dog",
            Breed = "Greyhound",
            RescueCenter = "Greyhounds of Florida",
            Zipcode = "33713",
            HousingType = "house",
            NeedYard = true,
            GoodWith = "cat and dog",
            GoodWithSmallChildren = true,
            IsActive = true,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "Jack is a retired race dog who wants to spend the rest of his days with a family who will love and care for him. He would do best in a home that has a fenced yard.",
            ImageUrl = "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665893/greyhound_yqahgy.jpg",
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
            Gender = "Female",
            CatOrDog = "cat",
            Breed = "Tabby",
            RescueCenter = "PetPal Animal Shelter",
            Zipcode = "33713",
            HousingType = "apartment",
            NeedYard = false,
            GoodWith = "cat",
            GoodWithSmallChildren = false,
            IsActive = false,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "Honey is a sweet girl who is looking for someone with a comfy lap and has time to pet her for days.",
            ImageUrl = "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665853/tabby_vuruuf.jpg",
            DateAdded = DateTime.Now,
          }
      );

      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 3,
            Name = "Buddy",
            Age = "4 years old",
            Gender = "Male",
            CatOrDog = "dog",
            Breed = "Golden Retriever",
            RescueCenter = "ASPCA",
            Zipcode = "33713",
            HousingType = "house",
            NeedYard = true,
            GoodWith = "cat and dog",
            GoodWithSmallChildren = true,
            IsActive = true,
            IsNeutered = false,
            IsVaccinated = true,
            Description = "Buddy is looking for a new family to take him home and play fetch all day and night. His favorite thing is play outside!",
            ImageUrl = "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665858/buddy_p2ej5y.jpg",
            DateAdded = DateTime.Now,
          }
      );

      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 4,
            Name = "Sweetie",
            Age = "7 years old",
            Gender = "Female",
            CatOrDog = "dog",
            Breed = "Terrier",
            RescueCenter = "ASPCA",
            Zipcode = "33713",
            HousingType = "apartment",
            NeedYard = false,
            GoodWith = "cat",
            GoodWithSmallChildren = false,
            IsActive = false,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "Sweetie justs wants to curl up on the couch next to you and watch movies all day. She will make the perfect snuggle baby for someone!",
            ImageUrl = "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665839/sweetie_plo8jp.jpg",
            DateAdded = DateTime.Now,
          }
      );

      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 5,
            Name = "Rocco",
            Age = "3 years old",
            Gender = "Male",
            CatOrDog = "dog",
            Breed = "Poodle",
            RescueCenter = "ASPCA",
            Zipcode = "33713",
            HousingType = "house",
            NeedYard = true,
            GoodWith = "none",
            GoodWithSmallChildren = true,
            IsActive = true,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "Rocco is a very rambunctious poodle with loads of spunky personality. Everyone on your block will know who Rocco is!",
            ImageUrl = "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665873/rocco_lrufwb.jpg",
            DateAdded = DateTime.Now,
          }
      );

      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 6,
            Name = "Sophie",
            Age = "2 years old",
            Gender = "Female",
            CatOrDog = "dog",
            Breed = "Pitbull",
            RescueCenter = "ASPCA",
            Zipcode = "33713",
            HousingType = "house",
            NeedYard = true,
            GoodWith = "none",
            GoodWithSmallChildren = true,
            IsActive = true,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "Sophie is a fun loving girl who wants to play always. Throw a frisbee or take her running, either way, she will keep up!",
            ImageUrl = "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665871/sophie_ol55co.jpg",
            DateAdded = DateTime.Now,
          }
      );

      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 7,
            Name = "Rex",
            Age = "3 years old",
            Gender = "Male",
            CatOrDog = "dog",
            Breed = "Siberian Husky",
            RescueCenter = "ASPCA",
            Zipcode = "33713",
            HousingType = "house",
            NeedYard = true,
            GoodWith = "none",
            GoodWithSmallChildren = true,
            IsActive = true,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "Rex would do really well in a home where he is the only animal. He needs a lot of attention as he is a working dog so someone who can commit to taking long walks with Rex would be perfect!",
            ImageUrl = "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665873/rex_tfv6ya.jpg",
            DateAdded = DateTime.Now,
          }
      );

      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 8,
            Name = "Chloe",
            Age = "2 years old",
            Gender = "Female",
            CatOrDog = "cat",
            Breed = "Domestic Short Hair",
            RescueCenter = "ASPCA",
            Zipcode = "33713",
            HousingType = "apartment",
            NeedYard = false,
            GoodWith = "cat",
            GoodWithSmallChildren = false,
            IsActive = false,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "Chloe wants all the pets in the whole world!",
            ImageUrl = "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665870/chloe_uyhyyu.jpg",
            DateAdded = DateTime.Now,
          }
      );

      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 9,
            Name = "Dexter",
            Age = "1 years old",
            Gender = "Male",
            CatOrDog = "cat",
            Breed = "Persian",
            RescueCenter = "ASPCA",
            Zipcode = "33713",
            HousingType = "apartment",
            NeedYard = false,
            GoodWith = "cat",
            GoodWithSmallChildren = false,
            IsActive = false,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "Dexter is the laziest Persian cat you have ever met. All he wants to do is be held in your arms while you pet him endlessly until he falls asleep!",
            ImageUrl = "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665887/dexter_qa3x0v.jpg",
            DateAdded = DateTime.Now,
          }
      );

      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 10,
            Name = "Ella",
            Age = "1 years old",
            Gender = "Female",
            CatOrDog = "cat",
            Breed = "Domestic Short Hair",
            RescueCenter = "ASPCA",
            Zipcode = "33713",
            HousingType = "apartment",
            NeedYard = false,
            GoodWith = "none",
            GoodWithSmallChildren = false,
            IsActive = false,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "Ella is looking for a new furever home!",
            ImageUrl = "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665883/ella_kknwpn.jpg",
            DateAdded = DateTime.Now,
          }
      );

      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 11,
            Name = "Simon",
            Age = "4 years old",
            Gender = "Male",
            CatOrDog = "cat",
            Breed = "Russian Blue",
            RescueCenter = "ASPCA",
            Zipcode = "33713",
            HousingType = "house",
            NeedYard = true,
            GoodWith = "cat and dog",
            GoodWithSmallChildren = true,
            IsActive = true,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "If you have ever wanted a cat who never stops exploring, you have found him! Simon loves to be outside and roam the outdoors but he will never venture too far from home!",
            ImageUrl = "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665891/simon_kf7ksd.jpg",
            DateAdded = DateTime.Now,
          }
      );

      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 12,
            Name = "Sheba",
            Age = "2 years old",
            Gender = "Female",
            CatOrDog = "cat",
            Breed = "Domestic Long Hair",
            RescueCenter = "ASPCA",
            Zipcode = "33713",
            HousingType = "apartment",
            NeedYard = false,
            GoodWith = "none",
            GoodWithSmallChildren = true,
            IsActive = false,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "Sheba will be the princess of the house with an attitude to match...but only because she wants attention!",
            ImageUrl = "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665886/sheba_q2wn4u.jpg",
            DateAdded = DateTime.Now,
          }
      );

      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 13,
            Name = "Nala",
            Age = "3 years old",
            Gender = "Female",
            CatOrDog = "cat",
            Breed = "Domestic Medium Hair",
            RescueCenter = "ASPCA",
            Zipcode = "33713",
            HousingType = "apartment",
            NeedYard = false,
            GoodWith = "none",
            GoodWithSmallChildren = true,
            IsActive = false,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "Nala wants nothing more than to find a spot perched high above your head so she can watch her family down below!",
            ImageUrl = "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665885/nala_yyucg3.jpg",
            DateAdded = DateTime.Now,
          }
      );

      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 14,
            Name = "Harry",
            Age = " 6 months old",
            Gender = "Male",
            CatOrDog = "cat",
            Breed = "Brown Tabby",
            RescueCenter = "ASPCA",
            Zipcode = "33713",
            HousingType = "apartment",
            NeedYard = false,
            GoodWith = "cat",
            GoodWithSmallChildren = true,
            IsActive = false,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "Just a little baby Harry is, someone love him!",
            ImageUrl = "https://res.cloudinary.com/do8vvvqfj/image/upload/v1587665885/harry_rtszsw.jpg",
            DateAdded = DateTime.Now,
          }
      );

      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 15,
            Name = "Maggie",
            Age = " 1 years old",
            Gender = "Female",
            CatOrDog = "dog",
            Breed = "Pug",
            RescueCenter = "PetPal Animal Shelter",
            Zipcode = "33713",
            HousingType = "house",
            NeedYard = true,
            GoodWith = "cat and dog",
            GoodWithSmallChildren = true,
            IsActive = true,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "Maggie loves to be a couch potato and will snuggle up right next to you!",
            ImageUrl = "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588008900/maggie_mvuo8d.jpg",
            DateAdded = DateTime.Now,
          }
      );

      base.OnModelCreating(builder);
      builder.Entity<Animal>().HasData(
          new Animal
          {
            Id = 16,
            Name = "Dunkin",
            Age = "5 years old",
            Gender = "Male",
            CatOrDog = "dog",
            Breed = "French Bulldog",
            RescueCenter = "PetPal Animal Shelter",
            Zipcode = "33713",
            HousingType = "house",
            NeedYard = true,
            GoodWith = "none",
            GoodWithSmallChildren = true,
            IsActive = true,
            IsNeutered = true,
            IsVaccinated = true,
            Description = "Dunkin is a very athletic dog that loves to play firsbee or pull you on your skateboard!",
            ImageUrl = "https://res.cloudinary.com/do8vvvqfj/image/upload/v1588009236/dunkin_glzbgz.jpg",
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
