using WebApplication.Model.Base;

namespace WebApplication.Repository.Generic
{
	public interface IRepository<T> where T : BaseEntity
	{
		Task<T> CreateAsync(T item);
		Task<T> FindByIdAsync(int id);
		Task<IEnumerable<T>> FindAllAsync();
		Task<T> UpdateAsync(T item);
		Task DeleteAsync(int id);
	}
}
