using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Application.Services.Interfaces;
using School.Domain.Models.DTOs;

namespace School.Web.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IUserservise _userservise;

		public AuthController(IUserservise userservise)
		{
			_userservise = userservise;
		}

		[HttpPost]
		public async Task<IActionResult> Register([FromBody] RegisterDTO dto, CancellationToken cancellationToken)
		{
			await _userservise.RegisterUserAsync(dto, cancellationToken);
			return Ok("User registered successfully");
		}

		[HttpPost]
		public async Task<IActionResult> Login([FromBody] LoginDTO dto, CancellationToken cancellationToken)
		{
			var isAuthenticated = await _userservise.LoginUserAsync(dto, cancellationToken);
			if (!isAuthenticated)
			{
				return Unauthorized("Invalid email or password");
			}
			return Ok("User logged in successfully");
		}

	}
}
