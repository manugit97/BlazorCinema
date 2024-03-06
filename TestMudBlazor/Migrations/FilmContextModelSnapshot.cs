﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestMudBlazor.Data;

#nullable disable

namespace TestMudBlazor.Migrations
{
    [DbContext(typeof(FilmContext))]
    partial class FilmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("TestMudBlazor.Data.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Cristopher Nolan",
                            Description = "A film about the creation of the nuclear bomb",
                            Genre = "History",
                            Name = "Oppenheimer",
                            Rating = 5
                        },
                        new
                        {
                            Id = 2,
                            Author = "Greta Gerwig",
                            Description = "A film about Barbie, the famous doll",
                            Genre = "Comedy",
                            Name = "Barbie",
                            Rating = 2
                        },
                        new
                        {
                            Id = 3,
                            Author = "James Wan",
                            Description = "A film about paranormal activities",
                            Genre = "Horror",
                            Name = "The Conjuring",
                            Rating = 3
                        },
                        new
                        {
                            Id = 4,
                            Author = "Roger Allers",
                            Description = "A film about Simba's life, a small lion cub",
                            Genre = "Animation",
                            Name = "The Lion King",
                            Rating = 4
                        },
                        new
                        {
                            Id = 5,
                            Author = "James Cameron",
                            Description = "A film about a cyborg assassin",
                            Genre = "Action",
                            Name = "Terminator",
                            Rating = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}