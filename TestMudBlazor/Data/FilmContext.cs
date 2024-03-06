using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration.Ini;
using Microsoft.Extensions.Options;
using System.ComponentModel;
using System.Data.Common;
using System.Net;

namespace TestMudBlazor.Data
{
	public class FilmContext : DbContext
	{
		protected readonly IConfiguration Configuration;

		public FilmContext(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite(Configuration.GetConnectionString("FilmDB"));
		}

		public DbSet<Film> Films { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			var films = new List<Film>()
			{
				new() { Id = 1, Name = "Oppenheimer", Author = "Cristopher Nolan", Description = "A film about the creation of the nuclear bomb", Genre = "History", Rating = 5 },
				new() { Id = 2, Name = "Barbie", Author = "Greta Gerwig", Description = "A film about Barbie, the famous doll", Genre = "Comedy", Rating = 2 },
				new() { Id = 3, Name = "The Conjuring", Author = "James Wan", Description = "A film about paranormal activities", Genre = "Horror", Rating = 3 },
				new() { Id = 4, Name = "The Lion King", Author = "Roger Allers", Description = "A film about Simba's life, a small lion cub", Genre = "Animation", Rating = 4 },
				new() { Id = 5, Name = "Terminator", Author = "James Cameron", Description = "A film about a cyborg assassin", Genre = "Action", Rating = 1 }
			};
			modelBuilder.Entity<Film>().HasData(films);
		}
	}

	public class Film
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Genre { get; set; }
		public string Author { get; set; }
		public int Rating { get; set; }

	}
}

