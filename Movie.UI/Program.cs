using Movie.Domain.DTOs;
using Movie.Domain.Entities;
using Movie.Infrastucture.Data;
using Movie.Infrastucture.Repositories;
using Movie.Service.Implementations;

namespace Movie.UI
{
	internal class Program
	{
		static async Task Main(string[] args)
		{

			var dbContext = new MovieDbContext();
			var movieRepository = new MovieRepository(dbContext);
			var movieService = new MovieService(movieRepository);





			//var studio = new Studio { Name = "Warner Bros", CountryId = 1 };
			//dbContext.Studios.Add(studio);
			//await dbContext.SaveChangesAsync();



			//var createMovieDto = new CreateMovieDTO { Title = "Home Alone", ReleaseYear = 1996, StudioId = 1 };
			//await movieService.AddMovieAsync(createMovieDto);
			//await dbContext.SaveChangesAsync();


			var movies = await movieService.GetAllMoviesAsync();
			foreach (var movie in movies)
			{
				Console.WriteLine(movie);
			}


		}
	}
}
