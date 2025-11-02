using API_Restful.Business.Interfaces;
using API_Restful.Data.Converter.Implementations;
using API_Restful.Data.Repository.Interfaces;
using API_Restful.Domain.Entities;

namespace API_Restful.Business.Implementations
{
	public class PersonService : IPersonService
	{
		private IRepository<Person> _repository;
		private readonly PersonConverter _personConverter;

		public PersonService(IRepository<Person> repository)
		{
			_repository = repository;
			_personConverter = new PersonConverter();
		}

		public List<PersonDTO> FindAll()
		{
			return _personConverter.ParseList(_repository.FindAll());
		}

		public PersonDTO FindById(int id)
		{
			return _personConverter.Parse(_repository.FindById(id));
		}

		public PersonDTO Create(PersonDTO personDTO)
		{
			var entity = _personConverter.Parse(personDTO);
			entity = _repository.Create(entity);

			return _personConverter.Parse(entity);
		}

		public PersonDTO Update(PersonDTO personDTO)
		{
			var entity = _personConverter.Parse(personDTO);
			entity = _repository.Update(entity);

			return _personConverter.Parse(entity);
		}
		public void Delete(int id)
		{
			_repository.Delete(id);
		}
	}
}