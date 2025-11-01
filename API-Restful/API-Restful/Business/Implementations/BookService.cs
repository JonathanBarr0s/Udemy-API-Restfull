using API_Restful.Business.Interfaces;
using API_Restful.Data.Repository.Interfaces;
using API_Restful.Domain.Entities;

namespace API_Restful.Business.Implementations
{
	public class BookService : IBookService
	{
		private IBookRepository _repository;

		public BookService(IBookRepository repository)
		{
			_repository = repository;
		}

		public List<Book> FindAll()
		{
			return _repository.FindAll();
		}

		public Book FindById(long id)
		{
			return _repository.FindById(id);
		}

		public Book Create(Book book)
		{
			return _repository.Create(book);
		}

		public Book Update(Book book)
		{
			return _repository.Update(book);
		}
		public void Delete(long id)
		{
			_repository.Delete(id);
		}
	}
}
