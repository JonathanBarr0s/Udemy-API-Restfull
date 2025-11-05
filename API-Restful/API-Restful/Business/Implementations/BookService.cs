using API_Restful.Business.Interfaces;
using API_Restful.Data.Converter.Implementations;
using API_Restful.Data.DTO;
using API_Restful.Data.Repository.Interfaces;
using API_Restful.Domain.Entities;
using Mapster;

namespace API_Restful.Business.Implementations
{
	public class BookService : IBookService
	{
		private IRepository<Book> _repository;

		public BookService(IRepository<Book> repository)
		{
			_repository = repository;
		}

		public List<BookDTO> FindAll()
		{
			return _repository.FindAll().Adapt<List<BookDTO>>();
		}

		public BookDTO FindById(int id)
		{
			return _repository.FindById(id).Adapt<BookDTO>();
		}

		public BookDTO Create(BookDTO bookDTO)
		{
			var entity = bookDTO.Adapt<Book>();
			entity = _repository.Create(entity);

			return entity.Adapt<BookDTO>();
		}

		public BookDTO Update(BookDTO bookDTO)
		{
			var entity = bookDTO.Adapt<Book>();
			entity = _repository.Update(entity);

			return entity.Adapt<BookDTO>();
		}
		public void Delete(int id)
		{
			_repository.Delete(id);
		}
	}
}
