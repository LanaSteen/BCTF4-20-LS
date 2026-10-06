using Microsoft.AspNetCore.Mvc;
using Movie.Service.Interfaces;

namespace Movie.Web1.ViewComponents
{
	public class LatestMoviesViewComponent : ViewComponent
	{
		private readonly IMovieService _movieService;

		public LatestMoviesViewComponent(IMovieService movieService)
		{
			_movieService = movieService;
		}



		public async Task<IViewComponentResult> InvokeAsync(int count = 3)
		{
			var movies = await _movieService.GetAllMoviesAsync();
			var latestMovies = movies
				.OrderByDescending(m => m.ReleaseYear)
				.Take(count)
				.ToList(); // Get the latestMovies
			return View(latestMovies);
		}



	}
}


// M  V   C 