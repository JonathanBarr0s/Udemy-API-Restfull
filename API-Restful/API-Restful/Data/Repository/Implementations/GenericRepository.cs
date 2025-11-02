using API_Restful.Data.Context;
using API_Restful.Data.Repository.Interfaces;
using API_Restful.Domain.Base;
using API_Restful.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_Restful.Data.Repository.Implementations
{
	public class GenericRepository<T> : IRepository<T> where T : BaseEntity
	{
		private AppDbContext _context;
		private DbSet<T> _dbSet;

		public GenericRepository(AppDbContext context)
		{
			_context = context;
			_dbSet = context.Set<T>();
		}

		public T Create(T item)
		{
			_dbSet.Add(item);
			_context.SaveChanges();
			return item;
		}

		public void Delete(int id)
		{
			var existingItem = _dbSet.Find(id);
			if (existingItem == null)
				return;
			_dbSet.Remove(existingItem);
			_context.SaveChanges();
		}

		public bool Exists(int id)
		{
			return _dbSet.Any(item => item.Id == id);
		}

		public List<T> FindAll()
		{
			return _dbSet.ToList();
		}

		public T FindById(int id)
		{
			return _dbSet.Find(id);
		}

		public T Update(T item)
		{
			var existingItem = _dbSet.Find(item.Id);
			if (existingItem == null)
				return null;

			_dbSet.Entry(existingItem).CurrentValues.SetValues(item);
			_context.SaveChanges();
			return item;
		}
	}
}
