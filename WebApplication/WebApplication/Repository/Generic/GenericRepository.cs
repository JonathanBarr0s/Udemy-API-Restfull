using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApplication.Data.Context;
using WebApplication.Model.Base;

namespace WebApplication.Repository.Generic
{
	public class GenericRepository<T> : IRepository<T> where T : BaseEntity
	{
		private readonly AppDbContext _context;

		private readonly DbSet<T> _dbSet;

		public GenericRepository(AppDbContext context)
		{
			_context = context;
			_dbSet = _context.Set<T>();
		}

		public async Task<T> CreateAsync(T item)
		{
			try
			{
				await _dbSet.AddAsync(item);
				await _context.SaveChangesAsync();
				return item;
			} catch (Exception)
			{

				throw;
			}

		}

		public async Task DeleteAsync(int id)
		{
			try
			{
				var item = await _dbSet.FindAsync(id);
				_dbSet.Remove(item);
				await _context.SaveChangesAsync();
			} catch (Exception)
			{
				throw;
			}
		}

		public async Task<IEnumerable<T>> FindAllAsync()
		{
			try
			{
				return await _dbSet.ToListAsync();
			} catch (Exception)
			{
				throw;
			}
		}

		public async Task<T> FindByIdAsync(int id)
		{
			try
			{
				return await _dbSet.SingleOrDefaultAsync(i => i.Id.Equals(id));
			} catch (Exception)
			{

				throw;
			}
		}

		public async Task<T> UpdateAsync(T item)
		{
			try
			{
				_dbSet.Update(item);
				await _context.SaveChangesAsync();
				return item;
			} catch (Exception)
			{
				throw;
			}
		}
	}
}
