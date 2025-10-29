using API_Restful.Business.Implementations;
using API_Restful.Business.Interfaces;
using API_Restful.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API_Restful.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PersonController : ControllerBase
	{
		private IPersonService _personService;
		private readonly ILogger<PersonController> _logger;

		public PersonController(ILogger<PersonController> logger, IPersonService personService)
		{
			_logger = logger;
			_personService = personService;
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(_personService.FindAll());
		}

		[HttpGet("{id}")]
		public IActionResult Get(long id)
		{
			var person = _personService.FindById(id);
			if (person == null)
			{
				return NotFound();
			}
			return Ok(person);
		}

		[HttpPost]
		public IActionResult Post([FromBody] Person person)
		{
			var createdPerson = _personService.Create(person);
			if (createdPerson == null)
			{
				return NotFound();
			}
			return Ok(createdPerson);
		}

		[HttpPut]
		public IActionResult Put([FromBody] Person person)
		{
			var createdPerson = _personService.Update(person);
			if (createdPerson == null)
			{
				return NotFound();
			}
			return Ok(createdPerson);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_personService.Delete(id);
			return NoContent();
		}
	}
}
