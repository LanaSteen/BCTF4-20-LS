using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Movie.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Infrastucture.Data
{
	public class MovieDbContext : DbContext
	{
		public DbSet<Movie.Domain.Entities.Movie> Movies { get; set; }
		public DbSet<Actor> Actors { get; set; }
		public DbSet<Coutnry> Directors { get; set; }
		public DbSet<Studio> Genres { get; set; }
		public DbSet<StudioDetails> StudioDetails { get; set; }



		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			IConfiguration configuration = new ConfigurationBuilder()
				.SetBasePath(AppContext.BaseDirectory)
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
				.Build();

			var _connectionString = configuration.GetConnectionString("DefaultConnection");

			optionsBuilder.UseSqlServer(_connectionString);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Movie.Domain.Entities.Movie>()
				.HasMany(m => m.Actors)
				.WithMany(a => a.Movies);

			modelBuilder.Entity<Movie.Domain.Entities.Movie>().Property(m => m.Title)
				.IsRequired()
				.HasMaxLength(100);



			modelBuilder.Entity<Studio>()
				.HasOne(s => s.StudioDetails)
				.WithOne(sd => sd.Studio)
				.HasForeignKey<StudioDetails>(sd => sd.StudioId);

			modelBuilder.Entity<Studio>().Property(m => m.Name)
					.IsRequired()
					.HasMaxLength(100);


			modelBuilder.Entity<Studio>()
				.HasMany(s => s.Movies)
				.WithOne(m => m.Studio)
				.HasForeignKey(m => m.StudioId);



			modelBuilder.Entity<Coutnry>()
				.HasMany(c => c.Studios)
				.WithOne(s => s.Country)
				.HasForeignKey(s => s.CountryId);


			modelBuilder.Entity<Actor>()
				.HasMany(a => a.Movies)
				.WithMany(m => m.Actors);


			//data seeding
			modelBuilder.Entity<Coutnry>()
				.HasData(
					new Coutnry { Id = 1, Name = "USA" },
					new Coutnry { Id = 2, Name = "UK" },
					new Coutnry { Id = 3, Name = "France" }
				);

		}
	}
}
