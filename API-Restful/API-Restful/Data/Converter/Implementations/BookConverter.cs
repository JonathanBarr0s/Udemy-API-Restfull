using API_Restful.Data.Converter.Contract;
using API_Restful.Data.DTO;
using API_Restful.Domain.Entities;

namespace API_Restful.Data.Converter.Implementations
{
	public class BookConverter : IParser<Book, BookDTO>, IParser<BookDTO, Book>
	{
		public Book Parse(BookDTO origin)
		{
			if (origin == null)
				return null;

			return new Book
			{
				Id = origin.Id,
				Title = origin.Title,
				Author = origin.Author,
				Price = origin.Price,
				LaunchDate = origin.LaunchDate
			};
		}

		public List<Book> ParseList(List<BookDTO> origin)
		{
			if (origin == null)
				return null;

			return origin.Select(item => Parse(item)).ToList();
		}

		public BookDTO Parse(Book origin)
		{
			if (origin == null)
				return null;

			return new BookDTO
			{
				Id = origin.Id,
				Title = origin.Title,
				Author = origin.Author,
				Price = origin.Price,
				LaunchDate = origin.LaunchDate
			};
		}			

		public List<BookDTO> ParseList(List<Book> origin)
		{
			if (origin == null)
				return null;

			return origin.Select(item => Parse(item)).ToList();
		}		
	}
}