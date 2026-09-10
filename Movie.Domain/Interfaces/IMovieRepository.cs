using System;
using System.Collections.Generic;
using Movie.Domain.Entities;
using System.Text;

namespace Movie.Domain.Interfaces
{
	public interface IMovieRepository
	{
		Task<ICollection<Movie.Domain.Entities.Movie>> GetAllMovies();
		Task AddMovie(Movie.Domain.Entities.Movie movie);
	}
}
