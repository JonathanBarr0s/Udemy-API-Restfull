using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication.Business.Interfaces;
using WebApplication.Data.Context;
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
		public IActionResult ListarTodos()
		{
			return Ok(_pessoaBusiness.FindAll());
		}

		[HttpGet("{id}")]
		public IActionResult BuscarPorId(int id)
		{
			return Ok(_pessoaBusiness.FindById(id));
		}

		[HttpPost]
		public IActionResult CriarNovo([FromBody] Pessoa pessoa)
		{
			return Ok(_pessoaBusiness.Create(pessoa));
		}

		[HttpPut]
		public IActionResult EditarPorId([FromBody] Pessoa pessoa)
		{
			return Ok(_pessoaBusiness.Update(pessoa));
		}


		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_pessoaBusiness.Delete(id);
			return NoContent();
		}
	}
}
