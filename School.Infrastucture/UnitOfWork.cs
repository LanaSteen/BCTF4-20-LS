using School.Domain.Interfaces;
using School.Infrastucture.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infrastucture
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly SchoolDbContext _context;

		public UnitOfWork(SchoolDbContext context)
		{
			_context = context;
		}

		public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			return await _context.SaveChangesAsync(cancellationToken);
		}
	}
}
