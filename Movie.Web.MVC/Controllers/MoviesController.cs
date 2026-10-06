using Microsoft.AspNetCore.Mvc;
using Movie.Service.Interfaces;

namespace Movie.Web.MVC.Controllers
{
	public class MoviesController : Controller
	{
		private readonly IMovieService _movieService;

		public MoviesController(IMovieService movieService)
		{
			_movieService = movieService;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var movies = await _movieService.GetAllMoviesAsync();

			return View(movies);
		}
	}
}
