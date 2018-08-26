using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Multi_UnitOfWork.Core
{
	public class UnitOfWork<T> : IUnitOfWork<T> where T : DbContext
	{
		private readonly DbContext _context;

		public UnitOfWork(T context)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context));
		}

		public DbSet<TEntity> Set<TEntity>() where TEntity : class
		{
			return _context.Set<TEntity>();
		}
	}
}