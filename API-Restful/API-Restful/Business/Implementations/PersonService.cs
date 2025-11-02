using API_Restful.Business.Interfaces;
using API_Restful.Data.Repository.Interfaces;
using API_Restful.Domain.Entities;

namespace API_Restful.Business.Implementations
{
	public class PersonService : IPersonService
	{
		private IRepository<Person> _repository;

		public PersonService(IRepository<Person> repository)
		{
			_repository = repository;
		}

		public List<Person> FindAll()
		{
			return _repository.FindAll();
		}

		public Person FindById(int id)
		{
			return _repository.FindById(id);
		}

		public Person Create(Person person)
		{
			return _repository.Create(person);
		}

		public Person Update(Person person)
		{
			return _repository.Update(person);
		}
		public void Delete(int id)
		{
			_repository.Delete(id);
		}
	}
}