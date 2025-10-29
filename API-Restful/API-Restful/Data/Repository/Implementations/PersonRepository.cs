using API_Restful.Data.Context;
using API_Restful.Data.Repository.Interfaces;
using API_Restful.Domain.Entities;

namespace API_Restful.Data.Repository.Implementations
{
	public class PersonRepository : IPersonRepository
	{
		private AppDbContext _context;

		public PersonRepository(AppDbContext context)
		{
			_context = context;
		}

		public List<Person> FindAll()
		{
			return _context.Persons.ToList();
		}

		public Person FindById(long id)
		{
			return _context.Persons.Find(id);
		}

		public Person Create(Person person)
		{
			_context.Add(person);
			_context.SaveChanges();
			return person;
		}

		public Person Update(Person person)
		{
			var existingPerson = _context.Persons.Find(person.Id);
			if (existingPerson == null)
				return null;

			_context.Entry(existingPerson).CurrentValues.SetValues(person);
			_context.SaveChanges();
			return person;
		}
		public void Delete(long id)
		{
			var existingPerson = _context.Persons.Find(id);
			if (existingPerson == null)
				return;
			_context.Remove(existingPerson);
			_context.SaveChanges();
		}
	}
}