using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication.Data.Context;
using WebApplication.Model;

namespace WebApplication.Controllers
{
	[ApiVersion("1.0")]
	[ApiController]
	[Route("api/[controller]/v{version:apiVersion}")]
	public class PessoaController : ControllerBase
	{
		private readonly AppDbContext _context;

		private readonly ILogger<PessoaController> _logger;

		public PessoaController(AppDbContext context, ILogger<PessoaController> logger)
		{
			_context = context;
			_logger = logger;
		}

		[HttpGet]
		public IActionResult ListarTodos()
		{
			return Ok(_context.Pessoa.ToList());
		}

		[HttpGet("{id}")]
		public IActionResult BuscarPorId(int id)
		{
			Pessoa pessoa = _context.Pessoa.FirstOrDefault(p => p.Id == id);
			if (pessoa == null) return NotFound();
			return Ok(pessoa);
		}

		[HttpPost]
		public IActionResult CriarNovo([FromBody] Pessoa pessoa)
		{
			if (pessoa == null)	return BadRequest();
			_context.Pessoa.Add(pessoa);
			_context.SaveChanges();

			return Created();
		}

		[HttpPut]
		public IActionResult EditarPorId([FromBody] Pessoa pessoa)
		{
			if (pessoa == null)	return BadRequest();
			_context.Update(pessoa);
			_context.SaveChanges();
			return NoContent();
		}


		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			Pessoa pessoa = _context.Pessoa.FirstOrDefault(p => p.Id == id);
			if (pessoa == null)	return NotFound();
			_context.Pessoa.Remove(pessoa);
			_context.SaveChanges();
			return Ok("Registro deletado com sucesso!");
		}
	}
}
