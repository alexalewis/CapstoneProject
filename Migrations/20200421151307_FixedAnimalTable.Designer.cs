﻿// <auto-generated />
using System;
using CapstoneProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CapstoneProject.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200421151307_FixedAnimalTable")]
    partial class FixedAnimalTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            CatOrDog = "Dog",
                            DateAdded = new DateTime(2020, 4, 21, 11, 13, 6, 652, DateTimeKind.Local).AddTicks(2770),
                            Description = "Jack is a retired race dog who wants to spend the rest of his days with a family who will love and care for him. He would do best in a home that has a fenced yard.",
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
                            CatOrDog = "Cat",
                            DateAdded = new DateTime(2020, 4, 21, 11, 13, 6, 653, DateTimeKind.Local).AddTicks(9370),
                            Description = "Honey is a sweet girl who is looking for someone with a comfy lap and has time to pet her for days.",
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

                    b.Property<bool>("IsFenced")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
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
