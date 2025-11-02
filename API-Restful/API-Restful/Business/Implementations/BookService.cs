using API_Restful.Business.Interfaces;
using API_Restful.Data.Converter.Implementations;
using API_Restful.Data.Repository.Interfaces;
using API_Restful.Domain.Entities;

namespace API_Restful.Business.Implementations
{
	public class BookService : IBookService
	{
		private IRepository<Book> _repository;
		private readonly BookConverter _bookConverter;

		public BookService(IRepository<Book> repository)
		{
			_repository = repository;
			_bookConverter = new BookConverter();
		}

		public List<BookDTO> FindAll()
		{
			return _bookConverter.ParseList(_repository.FindAll());
		}

		public BookDTO FindById(int id)
		{
			return _bookConverter.Parse(_repository.FindById(id));
		}

		public BookDTO Create(BookDTO bookDTO)
		{
			var entity = _bookConverter.Parse(bookDTO);
			entity = _repository.Create(entity);

			return _bookConverter.Parse(entity);
		}

		public BookDTO Update(BookDTO bookDTO)
		{
			var entity = _bookConverter.Parse(bookDTO);
			entity = _repository.Update(entity);

			return _bookConverter.Parse(entity);
		}
		public void Delete(int id)
		{
			_repository.Delete(id);
		}
	}
}
