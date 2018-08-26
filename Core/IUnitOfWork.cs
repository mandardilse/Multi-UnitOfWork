using Microsoft.EntityFrameworkCore;

namespace Multi_UnitOfWork.Core
{
	public interface IUnitOfWork<T> : IUnitOfWork where T : DbContext
	{
	}
	public interface IUnitOfWork
	{
		DbSet<T> Set<T>() where T : class;

	}
}