using Microsoft.AspNetCore.Mvc;
using WebApplication.Business.Interfaces;
using WebApplication.Data.VO;
using WebApplication.Hypermedia.Filters;
using WebApplication.Model;

namespace WebApplication.Controllers
{
	[ApiVersion("1.0")]
	[ApiController]
	[Route("api/[controller]/v{version:apiVersion}")]
	public class LivroController : ControllerBase
	{
		private readonly ILivroBusiness _livroBusiness;
		private readonly ILogger<LivroController> _logger;

		public LivroController(ILivroBusiness livroBusiness, ILogger<LivroController> logger)
		{
			_livroBusiness = livroBusiness;
			_logger = logger;
		}

		[HttpGet]
		[ProducesResponseType((200), Type = typeof(List<LivroVO>))]
		[ProducesResponseType(204)]
		[ProducesResponseType(400)]
		[ProducesResponseType(401)]
		[TypeFilter(typeof(HyperMediaFilter))]
		public async Task<IActionResult> FindAllAsync()
		{
			return Ok(await _livroBusiness.FindAllAsync());
		}

		[HttpGet("{id}")]
		[ProducesResponseType((200), Type = typeof(LivroVO))]
		[ProducesResponseType(204)]
		[ProducesResponseType(400)]
		[ProducesResponseType(401)]
		[TypeFilter(typeof(HyperMediaFilter))]
		public async Task<IActionResult> FindByIdAsync(int id)
		{
			return Ok(await _livroBusiness.FindByIdAsync(id));
		}

		[HttpPost]
		[ProducesResponseType((200), Type = typeof(LivroVO))]
		[ProducesResponseType(400)]
		[ProducesResponseType(401)]
		[TypeFilter(typeof(HyperMediaFilter))]
		public async Task<IActionResult> CreateAsync([FromBody] LivroVO livro)
		{
			return Ok(await _livroBusiness.CreateAsync(livro));
		}

		[HttpPut]
		[ProducesResponseType((200), Type = typeof(LivroVO))]
		[ProducesResponseType(400)]
		[ProducesResponseType(401)]
		[TypeFilter(typeof(HyperMediaFilter))]
		public async Task<IActionResult> UpdateAsync([FromBody] LivroVO livro)
		{
			return Ok(await _livroBusiness.UpdateAsync(livro));
		}

		[HttpDelete("{id}")]
		[ProducesResponseType(204)]
		[ProducesResponseType(400)]
		[ProducesResponseType(401)]
		public async Task<IActionResult> DeleteAsync(int id)
		{
			await _livroBusiness.DeleteAsync(id);
			return NoContent();
		}
	}
}
