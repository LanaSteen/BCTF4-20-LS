using Microsoft.Extensions.DependencyInjection;
using Movie.Domain.DTOs;
using Movie.Domain.Entities;
using Movie.Domain.Interfaces;
using Movie.Infrastucture.Data;
using Movie.Infrastucture.Repositories;
using Movie.Service.Implementations;
using Movie.Service.Interfaces;

namespace Movie.UI
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			#region without DI container

			//var dbContext = new MovieDbContext();
			//var movieRepository = new MovieRepository(dbContext);
			//var movieService = new MovieService(movieRepository);
			#endregion

			//DI container

			var servises = new ServiceCollection();

			servises.AddDbContext<MovieDbContext>();
			servises.AddScoped<IMovieRepository, MovieRepository>();
			servises.AddScoped<IMovieService, MovieService>();


			var serviceProvider = servises.BuildServiceProvider();

			var movieService = serviceProvider.GetRequiredService<IMovieService>();


			//var studio = new Studio { Name = "Warner Bros", CountryId = 1 };
			//dbContext.Studios.Add(studio);
			//await dbContext.SaveChangesAsync();



			//var createMovieDto = new CreateMovieDTO { Title = "Home Alone", ReleaseYear = 1996, StudioId = 1 };
			//await movieService.AddMovieAsync(createMovieDto);
			//await dbContext.SaveChangesAsync();


			var movieById = await movieService.GetMovieByIdAsync(1);
			Console.WriteLine(movieById);




			//var movies = await movieService.GetAllMoviesAsync();
			//foreach (var movie in movies)
			//{
			//	Console.WriteLine(movie);
			//}


		}
	}
}
