using WebApplication.Model;

namespace WebApplication.Repository
{
	public interface IPessoaRepository
	{
		Pessoa Create(Pessoa pessoa);
		Pessoa FindById(int id);
		List<Pessoa> FindAll();
		Pessoa Update(Pessoa pessoa);
		void Delete(int id);
	}
}
