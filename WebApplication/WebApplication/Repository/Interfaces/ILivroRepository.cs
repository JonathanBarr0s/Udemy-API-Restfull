using WebApplication.Model;

namespace WebApplication.Repository.Interfaces
{
	public interface ILivroRepository
	{
		Livro Create(Livro livro);
		Livro FindById(int id);
		List<Livro> FindAll();
		Livro Update(Livro livro);
		void Delete(int id);
	}
}
