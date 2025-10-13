using Microsoft.AspNetCore.Mvc;
using WebApplication.Business.Interfaces;
using WebApplication.Model;

namespace WebApplication.Controllers
{
	[ApiVersion("1.0")]
	[ApiController]
	[Route("api/[controller]/v{version:apiVersion}")]
	public class PessoaController : ControllerBase
	{
		private readonly IPessoaBusiness _pessoaBusiness;
		private readonly ILogger<PessoaController> _logger;

		public PessoaController(IPessoaBusiness pessoaBusiness, ILogger<PessoaController> logger)
		{
			_pessoaBusiness = pessoaBusiness;
			_logger = logger;
		}

		[HttpGet]
		public async Task<IActionResult> FindAllAsync()
		{
			return Ok(await _pessoaBusiness.FindAllAsync());
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> FindByIdAsync(int id)
		{
			return Ok(await _pessoaBusiness.FindByIdAsync(id));
		}

		[HttpPost]
		public async Task<IActionResult> CreateAsync([FromBody] Pessoa pessoa)
		{
			return Ok(await _pessoaBusiness.CreateAsync(pessoa));
		}

		[HttpPut]
		public async Task<IActionResult> UpdateAsync([FromBody] Pessoa pessoa)
		{
			return Ok(await _pessoaBusiness.UpdateAsync(pessoa));
		}


		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteAsync(int id)
		{
			await _pessoaBusiness.DeleteAsync(id);
			return NoContent();
		}
	}
}
