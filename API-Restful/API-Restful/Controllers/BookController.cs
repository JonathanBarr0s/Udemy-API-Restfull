using API_Restful.Business.Interfaces;
using API_Restful.Data.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API_Restful.Controllers
{
	[ApiController]
	[Route("[controller]")]
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
		public IActionResult Get(int id)
		{
			var book = _bookService.FindById(id);
			if (book == null)
			{
				return NotFound();
			}
			return Ok(book);
		}

		[HttpPost]
		public IActionResult Post([FromBody] BookDTO bookDTO)
		{
			var createdBook = _bookService.Create(bookDTO);
			if (createdBook == null)
			{
				return NotFound();
			}
			return Ok(createdBook);
		}

		[HttpPut]
		public IActionResult Put([FromBody] BookDTO bookDTO)
		{
			var createdBook = _bookService.Update(bookDTO);
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
