using Microsoft.EntityFrameworkCore;
using Movie.Domain.Interfaces;
using Movie.Infrastucture.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Infrastucture.Repositories
{
	public class MovieRepository : IMovieRepository
	{

		private readonly MovieDbContext _movieDbContext;
		public MovieRepository(MovieDbContext movieDbContext)
		{
			_movieDbContext = movieDbContext;
		}


		public async Task AddMovieAsync(Domain.Entities.Movie movie)
		{
		    await _movieDbContext.Movies.AddAsync(movie);
			//await _movieDbContext.SaveChangesAsync();
		}

		public async Task<ICollection<Domain.Entities.Movie>> GetAllMoviesAsync()
		{
			return await _movieDbContext.Movies
				.Include(m => m.Studio)
				.ToListAsync();
		}


		public async Task<Domain.Entities.Movie> GetMovieByIdAsync(int id)
		{
			return await _movieDbContext.Movies
				.Include(m => m.Studio)
				.FirstOrDefaultAsync(m => m.Id == id);
		}


		public async Task UpdateMovieAsync(int id, Domain.Entities.Movie movie)
		{
			var movieExists =
				await _movieDbContext.Movies
				.FirstOrDefaultAsync(m => m.Id == id);
			if (movieExists == null)
			{
				throw new ArgumentException("Movie not found");
			}

			movieExists.Title = movie.Title;
			movieExists.ReleaseYear = movie.ReleaseYear;
			movieExists.StudioId = movie.StudioId;


			//await _movieDbContext.SaveChangesAsync();
		}


		public async Task  DeleteMovieAsync(int id)
		{
			
			var movieExists = await _movieDbContext.Movies
				.FirstOrDefaultAsync(m => m.Id == id);
			if (movieExists == null)
			{
				throw new ArgumentException("Movie not found");
			}

			_movieDbContext.Movies.Remove(movieExists);
			//await _movieDbContext.SaveChangesAsync();

		}

	}
}
