using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Movie.Domain.DTOs;
using Movie.Service.Interfaces;

namespace Movie.Web1.Pages.Movies
{
    public class EditModel : PageModel
    {

		private readonly IMovieService _movieService;

		public EditModel(IMovieService movieService)
		{
			_movieService = movieService;
		}


		[BindProperty]
        public UpdateMovieDTO Movie { get; set; }
		public int Id { get; set; }




		public async Task OnGetAsync(int id)
		{
			Id = id;

			var movie = await _movieService.GetMovieByIdAsync(id);

			Movie = new UpdateMovieDTO
			{

				Title = movie.Title,
				StudioId = 1,
				ReleaseYear = movie.ReleaseYear
			};
		}
			

		public async Task OnPostAsync(int id)
		{
			
			try
			{
				await _movieService.UpdateMovieAsync(id, Movie);
				TempData["Success"] = "Movie updated successfully.";
			}
			catch (ArgumentException ex)
			{
				ModelState.AddModelError(string.Empty, ex.Message);
		
			}


		}
    }
}
