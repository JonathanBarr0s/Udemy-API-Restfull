using WebApplication.Model;

namespace WebApplication.Business.Interfaces
{
	public interface IPessoaBusiness
	{
		Pessoa Create(Pessoa pessoa);
		Pessoa FindById(int id);
		List<Pessoa> FindAll();
		Pessoa Update(Pessoa pessoa);
		void Delete(int id);
	}
}
