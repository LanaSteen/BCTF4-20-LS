using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Interfaces
{
	public interface IUnitOfWork
	{
		Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
	}
}
