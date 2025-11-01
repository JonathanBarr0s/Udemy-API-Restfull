using API_Restful.Domain.Entities;

namespace API_Restful.Data.Repository.Interfaces
{
	public interface IBookRepository
	{
		Book Create(Book book);

		Book FindById(long id);

		List<Book> FindAll();

		Book Update(Book book);

		void Delete(long id);
	}
}
