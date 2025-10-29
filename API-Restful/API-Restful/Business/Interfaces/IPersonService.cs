using API_Restful.Domain.Entities;

namespace API_Restful.Business.Interfaces
{
	public interface IPersonService
	{
		Person Create(Person person);

		Person FindById(long id);

		List<Person> FindAll();

		Person Update(Person person);

		void Delete(long id);
	}
}