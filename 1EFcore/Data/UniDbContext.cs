using _1EFcore.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1EFcore.Data
{
	internal class UniDbContext : DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<StudentProfile> Profiles { get; set; }
		public DbSet<Department> Departmets { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=LAPTOP-HE9JLDVE;Database=UNIEF;Trusted_Connection=True; TrustServerCertificate=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Student>()
				.HasMany(s => s.Courses)
				.WithMany(c => c.Students)
				.UsingEntity(st=> st.ToTable("StudentsCourses"));

			modelBuilder.Entity<Student>()
				.HasOne(s => s.Profile)
				.WithOne(p => p.Student)
				.HasForeignKey<StudentProfile>(p => p.StudentId);
			
			modelBuilder.Entity<Student>()
				.HasOne(s => s.Department)
				.WithMany(d => d.Students)
				.HasForeignKey(s => s.DepartmentId);
		}
	}
}
