
using Microsoft.EntityFrameworkCore;
using School.Domain.Interfaces;
using School.Infrastucture;
using School.Infrastucture.Data;
using School.Infrastucture.Repositories;

namespace School.Web
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
			builder.Services.AddOpenApi();


			///////// add context +
			
			  builder.Services.AddDbContext<SchoolDbContext>(options =>
			  {
				  options.UseSqlServer(builder.Configuration
					  .GetConnectionString("DefaultConnection"));
			  });

			builder.Services.AddScoped<IStudentRepository, StudentRepository>();
			builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();




			////


			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.MapOpenApi();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
