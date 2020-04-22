﻿// <auto-generated />
using System;
using CapstoneProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CapstoneProject.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CapstoneProject.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Age")
                        .HasColumnType("text");

                    b.Property<string>("Breed")
                        .HasColumnType("text");

                    b.Property<string>("CatOrDog")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("GoodWith")
                        .HasColumnType("text");

                    b.Property<bool>("GoodWithSmallChildren")
                        .HasColumnType("boolean");

                    b.Property<string>("HousingType")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNeutered")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsVaccinated")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<bool>("NeedYard")
                        .HasColumnType("boolean");

                    b.Property<string>("RescueCenter")
                        .HasColumnType("text");

                    b.Property<string>("Zipcode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = "4 years old",
                            Breed = "Greyhound",
                            CatOrDog = "dog",
                            DateAdded = new DateTime(2020, 4, 21, 22, 14, 55, 147, DateTimeKind.Local).AddTicks(6360),
                            Description = "Jack is a retired race dog who wants to spend the rest of his days with a family who will love and care for him. He would do best in a home that has a fenced yard.",
                            Gender = "Male",
                            GoodWith = "cat and dog",
                            GoodWithSmallChildren = true,
                            HousingType = "house",
                            ImageUrl = "../images/greyhound.jpg",
                            IsActive = true,
                            IsNeutered = true,
                            IsVaccinated = true,
                            Name = "Jack",
                            NeedYard = true,
                            RescueCenter = "Greyhounds of Florida",
                            Zipcode = "33713"
                        },
                        new
                        {
                            Id = 2,
                            Age = "6 years old",
                            Breed = "Tabby",
                            CatOrDog = "cat",
                            DateAdded = new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7580),
                            Description = "Honey is a sweet girl who is looking for someone with a comfy lap and has time to pet her for days.",
                            Gender = "Female",
                            GoodWith = "cat and dog",
                            GoodWithSmallChildren = true,
                            HousingType = "house",
                            ImageUrl = "../images/tabby.jpg",
                            IsActive = false,
                            IsNeutered = true,
                            IsVaccinated = true,
                            Name = "Honey",
                            NeedYard = false,
                            RescueCenter = "PetPal Animal Shelter",
                            Zipcode = "33713"
                        },
                        new
                        {
                            Id = 3,
                            Age = "4 years old",
                            Breed = "Golden Retriever",
                            CatOrDog = "dog",
                            DateAdded = new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7630),
                            Description = "Buddy is looking for a new family to take him home and play fetch all day and night. His favorite thing is play outside!",
                            Gender = "Male",
                            GoodWith = "dog",
                            GoodWithSmallChildren = true,
                            HousingType = "house",
                            ImageUrl = "../images/buddy.jpg",
                            IsActive = true,
                            IsNeutered = false,
                            IsVaccinated = true,
                            Name = "Buddy",
                            NeedYard = true,
                            RescueCenter = "ASPCA",
                            Zipcode = "33713"
                        },
                        new
                        {
                            Id = 4,
                            Age = "7 years old",
                            Breed = "Terrier",
                            CatOrDog = "dog",
                            DateAdded = new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7660),
                            Description = "Sweetie justs wants to curl up on the couch next to you and watch movies all day. She will make the perfect snuggle baby for someone!",
                            Gender = "Female",
                            GoodWith = "cat and dog",
                            GoodWithSmallChildren = false,
                            HousingType = "apartment",
                            ImageUrl = "../images/sweetie.jpg",
                            IsActive = false,
                            IsNeutered = true,
                            IsVaccinated = true,
                            Name = "Sweetie",
                            NeedYard = false,
                            RescueCenter = "ASPCA",
                            Zipcode = "33713"
                        },
                        new
                        {
                            Id = 5,
                            Age = "3 years old",
                            Breed = "Poodle",
                            CatOrDog = "dog",
                            DateAdded = new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7680),
                            Description = "Rocco is a very rambunctious poodle with loads of spunky personality. Everyone on your block will know who Rocco is!",
                            Gender = "Male",
                            GoodWith = "none",
                            GoodWithSmallChildren = true,
                            HousingType = "apartment",
                            ImageUrl = "../images/rocco.jpg",
                            IsActive = false,
                            IsNeutered = true,
                            IsVaccinated = true,
                            Name = "Rocco",
                            NeedYard = false,
                            RescueCenter = "ASPCA",
                            Zipcode = "33713"
                        },
                        new
                        {
                            Id = 6,
                            Age = "2 years old",
                            Breed = "Pitbull",
                            CatOrDog = "dog",
                            DateAdded = new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7710),
                            Description = "Sophie is a fun loving girl who wants to play always. Throw a frisbee or taking her running, either way, she will keep up!",
                            Gender = "Female",
                            GoodWith = "none",
                            GoodWithSmallChildren = true,
                            HousingType = "house",
                            ImageUrl = "../images/sophie.jpg",
                            IsActive = true,
                            IsNeutered = true,
                            IsVaccinated = true,
                            Name = "Sophie",
                            NeedYard = true,
                            RescueCenter = "ASPCA",
                            Zipcode = "33713"
                        },
                        new
                        {
                            Id = 7,
                            Age = "3 years old",
                            Breed = "Siberian Husky",
                            CatOrDog = "dog",
                            DateAdded = new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7730),
                            Description = "Rex would do really well in a home where he is the only animal. He needs a lot of attention as he is a workind dog so someone who can commit to taking long walks with Rex would be perfect!",
                            Gender = "Male",
                            GoodWith = "none",
                            GoodWithSmallChildren = false,
                            HousingType = "house",
                            ImageUrl = "../images/rex.jpg",
                            IsActive = true,
                            IsNeutered = true,
                            IsVaccinated = true,
                            Name = "Rex",
                            NeedYard = true,
                            RescueCenter = "ASPCA",
                            Zipcode = "33713"
                        },
                        new
                        {
                            Id = 8,
                            Age = "2 years old",
                            Breed = "Domestic Short Hair",
                            CatOrDog = "cat",
                            DateAdded = new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7750),
                            Description = "Chloe wants all the pets in the whole world!",
                            Gender = "Female",
                            GoodWith = "cat",
                            GoodWithSmallChildren = false,
                            HousingType = "apartment",
                            ImageUrl = "../images/chloe.jpg",
                            IsActive = false,
                            IsNeutered = true,
                            IsVaccinated = true,
                            Name = "Chloe",
                            NeedYard = false,
                            RescueCenter = "ASPCA",
                            Zipcode = "33713"
                        },
                        new
                        {
                            Id = 9,
                            Age = "1 years old",
                            Breed = "Persian",
                            CatOrDog = "cat",
                            DateAdded = new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7770),
                            Description = "Dexter is the laziest Persian cat you have ever met. All he wants to do is be held in your arms while you pet him endlessly until he falls asleep!",
                            Gender = "Male",
                            GoodWith = "none",
                            GoodWithSmallChildren = true,
                            HousingType = "apartment",
                            ImageUrl = "../images/dexter.jpg",
                            IsActive = false,
                            IsNeutered = true,
                            IsVaccinated = true,
                            Name = "Dexter",
                            NeedYard = false,
                            RescueCenter = "ASPCA",
                            Zipcode = "33713"
                        },
                        new
                        {
                            Id = 10,
                            Age = "1 years old",
                            Breed = "Domestic Short Hair",
                            CatOrDog = "cat",
                            DateAdded = new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7790),
                            Description = "Ella is looking for a new furever home!",
                            Gender = "Female",
                            GoodWith = "none",
                            GoodWithSmallChildren = false,
                            HousingType = "apartment",
                            ImageUrl = "../images/ella.jpg",
                            IsActive = false,
                            IsNeutered = true,
                            IsVaccinated = true,
                            Name = "Ella",
                            NeedYard = false,
                            RescueCenter = "ASPCA",
                            Zipcode = "33713"
                        },
                        new
                        {
                            Id = 11,
                            Age = "4 years old",
                            Breed = "Russian Blue",
                            CatOrDog = "cat",
                            DateAdded = new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7810),
                            Description = "If you have ever wanted a cat who never stops exploring, you have found him! Simon loves to be outside and roam the outdoors but he will never venture too far from home!",
                            Gender = "Male",
                            GoodWith = "cat and dog",
                            GoodWithSmallChildren = true,
                            HousingType = "house",
                            ImageUrl = "../images/simon.jpg",
                            IsActive = true,
                            IsNeutered = true,
                            IsVaccinated = true,
                            Name = "Simon",
                            NeedYard = true,
                            RescueCenter = "ASPCA",
                            Zipcode = "33713"
                        },
                        new
                        {
                            Id = 12,
                            Age = "2 years old",
                            Breed = "Domestic Long Hair",
                            CatOrDog = "cat",
                            DateAdded = new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7900),
                            Description = "Sheba will be the princess of the house with an attitude to match...but only because she wants attention!",
                            Gender = "Female",
                            GoodWith = "none",
                            GoodWithSmallChildren = true,
                            HousingType = "apartment",
                            ImageUrl = "../images/sheba.jpg",
                            IsActive = false,
                            IsNeutered = true,
                            IsVaccinated = true,
                            Name = "Sheba",
                            NeedYard = false,
                            RescueCenter = "ASPCA",
                            Zipcode = "33713"
                        },
                        new
                        {
                            Id = 13,
                            Age = "3 years old",
                            Breed = "Domestic Medium Hair",
                            CatOrDog = "cat",
                            DateAdded = new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7930),
                            Description = "Nala wants nothing more than to find a spot perched high above your head so she can watch her family down below!",
                            Gender = "Female",
                            GoodWith = "none",
                            GoodWithSmallChildren = true,
                            HousingType = "apartment",
                            ImageUrl = "../images/nala.jpg",
                            IsActive = false,
                            IsNeutered = true,
                            IsVaccinated = true,
                            Name = "Nala",
                            NeedYard = false,
                            RescueCenter = "ASPCA",
                            Zipcode = "33713"
                        },
                        new
                        {
                            Id = 14,
                            Age = " 6 months old",
                            Breed = "Brown Tabby",
                            CatOrDog = "cat",
                            DateAdded = new DateTime(2020, 4, 21, 22, 14, 55, 148, DateTimeKind.Local).AddTicks(7950),
                            Description = "Just a little baby Harry is, someone love him!",
                            Gender = "Male",
                            GoodWith = "cat",
                            GoodWithSmallChildren = true,
                            HousingType = "apartment",
                            ImageUrl = "../images/harry.jpg",
                            IsActive = false,
                            IsNeutered = true,
                            IsVaccinated = true,
                            Name = "Harry",
                            NeedYard = false,
                            RescueCenter = "ASPCA",
                            Zipcode = "33713"
                        });
                });

            modelBuilder.Entity("CapstoneProject.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AnimalId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("UserId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("CapstoneProject.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Age")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("HashedPassword")
                        .HasColumnType("text");

                    b.Property<bool>("HaveYard")
                        .HasColumnType("boolean");

                    b.Property<string>("HousingType")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("LookingFor")
                        .HasColumnType("text");

                    b.Property<bool>("OtherAnimals")
                        .HasColumnType("boolean");

                    b.Property<bool>("SmallChildren")
                        .HasColumnType("boolean");

                    b.Property<string>("TypeOfOtherAnimal")
                        .HasColumnType("text");

                    b.Property<string>("Zipcode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CapstoneProject.Models.Match", b =>
                {
                    b.HasOne("CapstoneProject.Models.Animal", "animal")
                        .WithMany("Match")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CapstoneProject.Models.User", "user")
                        .WithMany("Match")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
