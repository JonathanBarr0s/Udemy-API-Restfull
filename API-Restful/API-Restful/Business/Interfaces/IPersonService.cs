using API_Restful.Data.DTO;

namespace API_Restful.Business.Interfaces
{
	public interface IPersonService
	{
		PersonDTO Create(PersonDTO personDTO);

		PersonDTO FindById(int id);

		List<PersonDTO> FindAll();

		PersonDTO Update(PersonDTO personDTO);

		void Delete(int id);
	}
}