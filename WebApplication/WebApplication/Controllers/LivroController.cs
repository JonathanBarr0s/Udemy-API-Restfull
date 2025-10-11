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
		public IActionResult ListarTodos()
		{
			return Ok(_livroBusiness.FindAll());
		}

		[HttpGet("{id}")]
		public IActionResult BuscarPorId(int id)
		{
			return Ok(_livroBusiness.FindById(id));
		}

		[HttpPost]
		public IActionResult CriarNovo([FromBody] Livro livro)
		{
			return Ok(_livroBusiness.Create(livro));
		}

		[HttpPut]
		public IActionResult EditarPorId([FromBody] Livro livro)
		{
			return Ok(_livroBusiness.Update(livro));
		}


		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_livroBusiness.Delete(id);
			return NoContent();
		}
	}
}
