using Movie.Domain.DTOs;
using Movie.Domain.Interfaces;
using Movie.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Service.Implementations
{
	public class MovieService : IMovieService
	{

		private readonly IMovieRepository _movieRepository;

		public MovieService(IMovieRepository movieRepository) {
			_movieRepository = movieRepository;
		}



		public async Task<ICollection<MovieDTO>> GetAllMoviesAsync()
		{
			var movies = await _movieRepository.GetAllMoviesAsync();

			var movieDtos = movies.Select(m => new MovieDTO
			{
				Title = m.Title,
				ReleaseYear = m.ReleaseYear,
				StudioName = m.Studio.Name,
			}).ToList();


			return movieDtos;
		}


		public async Task AddMovieAsync(CreateMovieDTO movieDto)
		{

			if(movieDto == null)
			{
				throw new ArgumentNullException(nameof(movieDto));
			}
			if (string.IsNullOrWhiteSpace(movieDto.Title))
			{
				throw new ArgumentException("Movie title cannot be null or empty.", nameof(movieDto.Title));
			}
			if (movieDto.ReleaseYear < 0)
			{
				throw new ArgumentException("Movie release year cannot be negative.", nameof(movieDto.ReleaseYear));
			}
			if (movieDto.ReleaseYear > DateTime.Now.Year)
			{
				throw new ArgumentException("Movie release year cannot be from future.", nameof(movieDto.ReleaseYear));
			}
			if (movieDto.StudioId <= 0)
			{
				throw new ArgumentException("Movie studio ID must be a positive integer.", nameof(movieDto.StudioId));
			}

			var movie = new Movie.Domain.Entities.Movie
			{
				Title = movieDto.Title,
				ReleaseYear = movieDto.ReleaseYear,
				StudioId = movieDto.StudioId
			};


			await _movieRepository.AddMovieAsync(movie);
		}

	}
}
