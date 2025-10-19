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
		[ProducesResponseType((200), Type = typeof(List<PessoaVO>))]
		[ProducesResponseType(204)]
		[ProducesResponseType(400)]
		[ProducesResponseType(401)]
		[TypeFilter(typeof(HyperMediaFilter))]
		public async Task<IActionResult> FindAllAsync()
		{
			return Ok(await _pessoaBusiness.FindAllAsync());
		}

		[HttpGet("{id}")]
		[ProducesResponseType((200), Type = typeof(PessoaVO))]
		[ProducesResponseType(204)]
		[ProducesResponseType(400)]
		[ProducesResponseType(401)]
		[TypeFilter(typeof(HyperMediaFilter))]
		public async Task<IActionResult> FindByIdAsync(int id)
		{
			return Ok(await _pessoaBusiness.FindByIdAsync(id));
		}

		[HttpPost]
		[ProducesResponseType((200), Type = typeof(PessoaVO))]
		[ProducesResponseType(400)]
		[ProducesResponseType(401)]
		[TypeFilter(typeof(HyperMediaFilter))]
		public async Task<IActionResult> CreateAsync([FromBody] PessoaVO pessoa)
		{
			return Ok(await _pessoaBusiness.CreateAsync(pessoa));
		}

		[HttpPut]
		[ProducesResponseType((200), Type = typeof(PessoaVO))]
		[ProducesResponseType(400)]
		[ProducesResponseType(401)]
		[TypeFilter(typeof(HyperMediaFilter))]
		public async Task<IActionResult> UpdateAsync([FromBody] PessoaVO pessoa)
		{
			return Ok(await _pessoaBusiness.UpdateAsync(pessoa));
		}


		[HttpDelete("{id}")]
		[ProducesResponseType(204)]
		[ProducesResponseType(400)]
		[ProducesResponseType(401)]
		public async Task<IActionResult> DeleteAsync(int id)
		{
			await _pessoaBusiness.DeleteAsync(id);
			return NoContent();
		}
	}
}
