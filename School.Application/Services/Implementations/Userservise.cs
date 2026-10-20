using Microsoft.AspNetCore.Identity;
using School.Application.Services.Interfaces;
using School.Domain.Models.DTOs;
using School.Infrastucture.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.Services.Implementations
{
	public class Userservise : IUserservise
	{
		//private readonly RoleManager<IdentityRole> _roleManager;
		private  readonly UserManager<ApplicationUser> _userManager;

		public Userservise(UserManager<ApplicationUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task RegisterUserAsync(RegisterDTO dto, CancellationToken cancellationToken = default)
		{
			var user = new ApplicationUser
			{
				Email = dto.Email,
				UserName = dto.Email

			};
			var result = await _userManager.CreateAsync(user, dto.Password);
			if (!result.Succeeded)
			{
				throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));
			}
		}

		//public async Task<bool> LoginUserAsync(LoginDTO dto, CancellationToken cancellationToken = default)
		//{
		//	var user = await _userManager.FindByEmailAsync(dto.Email);
		//	if (user == null)
		//	{
		//		return false;
		//	}
		//	var result = await _userManager.CheckPasswordAsync(user, dto.Password);
		//	return result;
		//}


	}
}
