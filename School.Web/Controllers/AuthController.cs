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
		private readonly IAuthServise _authServise;

		public AuthController(IUserservise userservise, IAuthServise authServise)
		{
			_userservise = userservise;
			_authServise = authServise;
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
			var result= await _authServise.LoginUserAsync(dto, cancellationToken);
			if (result == null)
			{
				return Unauthorized("Invalid email or password");
			}
			return Ok(result);
		}

	}
}
