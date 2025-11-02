using API_Restful.Domain.Entities;

namespace API_Restful.Business.Interfaces
{
	public interface IBookService
	{
		BookDTO Create(BookDTO bookDTO);

		BookDTO FindById(int id);

		List<BookDTO> FindAll();

		BookDTO Update(BookDTO bookDTO);

		void Delete(int id);
	}
}
