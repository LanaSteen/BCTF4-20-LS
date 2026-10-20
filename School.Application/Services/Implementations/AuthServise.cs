using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using School.Application.Services.Interfaces;
using School.Domain.Models.DTOs;
using School.Infrastucture.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace School.Application.Services.Implementations
{

	public class AuthServise : IAuthServise
	{

		private readonly IConfiguration _configuration;
		private readonly UserManager<ApplicationUser> _userManager;


		public AuthServise(IConfiguration configuration,
			UserManager<ApplicationUser> userManager)
		{
			_configuration = configuration;
			_userManager = userManager;
		}

		private AuthResponseDTO GenerateJwtToken(ApplicationUser user)
		{
			var jwtKey = _configuration["Jwt:Key"];
			var issuer = _configuration["Jwt:Issuer"];
			var audience = _configuration["Jwt:Audience"];
			var expireMinutes = int.Parse(_configuration["Jwt:ExpirationInMinutes"]);
			var expiresAt = DateTime.UtcNow.AddMinutes(expireMinutes);

			var claims = new List<Claim>
		{
			new Claim(ClaimTypes.NameIdentifier, user.Id),
			new Claim(ClaimTypes.Email, user.Email),
			new Claim(ClaimTypes.Name, user.UserName)
		};

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));

			var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

			var token = new JwtSecurityToken(
				issuer,
				audience,
				claims,
				expires: expiresAt,
				signingCredentials: credentials
			);

			var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

			return new AuthResponseDTO
			{
				Token = tokenString,
				ExpiresAt = expiresAt
			};
		}



		public async Task<AuthResponseDTO> LoginUserAsync(LoginDTO dto, CancellationToken cancellationToken = default)
		{
			var user = await _userManager.FindByEmailAsync(dto.Email);

			if (user == null || !await _userManager.CheckPasswordAsync(user, dto.Password))
			{
				throw new UnauthorizedAccessException("Invalid email or password.");
			}
			return GenerateJwtToken(user);

		}
	}
}
