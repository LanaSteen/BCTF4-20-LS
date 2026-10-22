
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using School.Application.Services.Implementations;
using School.Application.Services.Interfaces;
using School.Domain.Interfaces;
using School.Infrastucture;
using School.Infrastucture.Data;
using School.Infrastucture.FileStorage;
using School.Infrastucture.Identity;
using School.Infrastucture.Repositories;
using System.Text;

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

			builder.Services.AddScoped<IStudentService, StudentService>();
			builder.Services.AddScoped<IUserservise, Userservise>();
			builder.Services.AddScoped<IAuthServise, AuthServise>();

			builder.Services.AddScoped<IStudentProfileRepository, StudentProfileRepository>();
			builder.Services.AddScoped<IStudentProfileService, StudentProfileService>();



			/////   file servise add 
			var webRootPath = builder.Environment.WebRootPath ?? Path.Combine(builder.Environment.ContentRootPath, "wwwroot");
			builder.Services.AddSingleton<IFileStorageService>(new LocalFileStorageServise(webRootPath));

			////
			///  swagger add +

			builder.Services.AddEndpointsApiExplorer();
			//builder.Services.AddSwaggerGen();
			builder.Services.AddSwaggerGen(options =>
			{
				options.SwaggerDoc("v1", new OpenApiInfo
				{
					Title = "School API",
					Version = "v1"
				});
				options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
				{
					In = ParameterLocation.Header,
					Description = "Please enter a valid token",
					Name = "Authorization",
					Type = SecuritySchemeType.Http,
					BearerFormat = "JWT",
					Scheme = "Bearer"
				});
				options.AddSecurityRequirement(document =>

					new OpenApiSecurityRequirement
					{
						[new OpenApiSecuritySchemeReference(
							 "Bearer",
							 document)] = []
					});

			});



			////
			///  automapper add +
			//builder.Services.AddAutoMapper(cfg=> { },typeof(Program).Assembly);
			builder.Services.AddAutoMapper(cfg => { },
				typeof(Program).Assembly, 
				typeof(StudentService).Assembly);
			/////


			/// add identity + 
			builder.Services.AddIdentityCore<ApplicationUser>()
				.AddEntityFrameworkStores<SchoolDbContext>();
			/// 

			////  jwt +
			var jwtKey = builder.Configuration["Jwt:Key"];
			builder.Services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			}).AddJwtBearer(options =>
			{
				options.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					ValidIssuer = builder.Configuration["Jwt:Issuer"],
					ValidAudience = builder.Configuration["Jwt:Audience"],
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey))
				};
			});
			//////



			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.MapOpenApi();
			
			}

			///  add for swagger  +
			app.UseSwagger();
			app.UseSwaggerUI();

			//////
			///
			app.UseStaticFiles();  // + for root files

			app.UseHttpsRedirection();


			app.UseAuthentication();
			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
