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


		public async Task AddMovie(Domain.Entities.Movie movie)
		{
		    _movieDbContext.Movies.Add(movie);
			 _movieDbContext.SaveChanges();
		}

		public async Task<ICollection<Domain.Entities.Movie>> GetAllMovies()
		{
			return _movieDbContext.Movies
				.Include(m => m.Studio)
				.ToList();
		}
	}
}
