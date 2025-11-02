using API_Restful.Domain.Entities;

namespace API_Restful.Business.Interfaces
{
	public interface IBookService
	{
		Book Create(Book book);

		Book FindById(int id);

		List<Book> FindAll();

		Book Update(Book book);

		void Delete(int id);
	}
}
