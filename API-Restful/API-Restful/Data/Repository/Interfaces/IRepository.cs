using API_Restful.Domain.Base;
using API_Restful.Domain.Entities;

namespace API_Restful.Data.Repository.Interfaces
{
	public interface IRepository<T> where T : BaseEntity
	{
		T Create(T item);

		T FindById(int id);

		List<T> FindAll();

		T Update(T item);

		void Delete(int id);

		bool Exists(int id);
	}
}
