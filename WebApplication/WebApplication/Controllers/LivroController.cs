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
		[TypeFilter(typeof(HyperMediaFilter))]
		public async Task<IActionResult> FindAllAsync()
		{
			return Ok(await _livroBusiness.FindAllAsync());
		}

		[HttpGet("{id}")]
		[TypeFilter(typeof(HyperMediaFilter))]
		public async Task<IActionResult> FindByIdAsync(int id)
		{
			return Ok(await _livroBusiness.FindByIdAsync(id));
		}

		[HttpPost]
		[TypeFilter(typeof(HyperMediaFilter))]
		public async Task<IActionResult> CreateAsync([FromBody] LivroVO livro)
		{
			return Ok(await _livroBusiness.CreateAsync(livro));
		}

		[HttpPut]
		[TypeFilter(typeof(HyperMediaFilter))]
		public async Task<IActionResult> UpdateAsync([FromBody] LivroVO livro)
		{
			return Ok(await _livroBusiness.UpdateAsync(livro));
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteAsync(int id)
		{
			await _livroBusiness.DeleteAsync(id);
			return NoContent();
		}
	}
}
