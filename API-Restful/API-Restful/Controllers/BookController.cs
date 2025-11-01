using API_Restful.Business.Interfaces;
using API_Restful.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API_Restful.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BookController : ControllerBase
	{
		private IBookService _bookService;
		private readonly ILogger<BookController> _logger;

		public BookController(IBookService bookService,
			ILogger<BookController> logger)
		{
			_bookService = bookService;
			_logger = logger;
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(_bookService.FindAll());
		}

		[HttpGet("{id}")]
		public IActionResult Get(long id)
		{
			var book = _bookService.FindById(id);
			if (book == null)
			{
				return NotFound();
			}
			return Ok(book);
		}

		[HttpPost]
		public IActionResult Post([FromBody] Book book)
		{
			var createdBook = _bookService.Create(book);
			if (createdBook == null)
			{
				return NotFound();
			}
			return Ok(createdBook);
		}

		[HttpPut]
		public IActionResult Put([FromBody] Book book)
		{
			var createdBook = _bookService.Update(book);
			if (createdBook == null)
			{
				return NotFound();
			}
			return Ok(createdBook);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_bookService.Delete(id);
			return NoContent();
		}
	}
}
