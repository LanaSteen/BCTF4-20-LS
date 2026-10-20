using School.Domain.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.Services.Interfaces
{
	public interface IAuthServise
	{
		Task<AuthResponseDTO> LoginUserAsync(LoginDTO dto, CancellationToken cancellationToken = default);
	}
}
