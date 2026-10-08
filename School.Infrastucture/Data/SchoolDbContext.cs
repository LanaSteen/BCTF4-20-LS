using Microsoft.EntityFrameworkCore;
using School.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infrastucture.Data
{
	public class SchoolDbContext : DbContext
	{
		public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
		{
		}



		public DbSet<Student> Students { get; set; } //[dsdsd, dsds, dsds]
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Subject> Subjects { get; set; }
		public DbSet<Enrolment> Enrolments { get; set; }
		public DbSet<StudentProfile> StudentProfiles { get; set; }




		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);


			modelBuilder.Entity<Student>()
				.HasOne(s => s.StudentProfile)
				.WithOne(sp => sp.Student)
				.HasForeignKey<StudentProfile>(sp => sp.StudentId);

			modelBuilder.Entity<StudentProfile>()
				.HasOne(sp => sp.Student)
				.WithOne(s => s.StudentProfile)
				.HasForeignKey<StudentProfile>(sp => sp.StudentId);  // todo

			modelBuilder.Entity<Subject>()
				.HasOne(s => s.Teacher)
				.WithMany(t => t.Subjects)
				.HasForeignKey(s => s.TeacherId);

			modelBuilder.Entity<Enrolment>()
				.HasOne(e => e.Student)
				.WithMany(s => s.Enrolments)
				.HasForeignKey(e => e.StudentId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Enrolment>()
				.HasOne(e => e.Subject)
				.WithMany(s => s.Enrolments)
				.HasForeignKey(e => e.SubjectId)
				.OnDelete(DeleteBehavior.Cascade);


			modelBuilder.Entity<Student>(entity =>
			{
				//entity.HasKey(e => e.Id); // not needed, by convention
				entity.Property(e => e.FirstName).IsRequired().HasMaxLength(100);
				entity.Property(e => e.LastName).IsRequired().HasMaxLength(100);
				entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
				entity.Property(e => e.DateOfBirth).IsRequired();
			});
		}
	}
}
