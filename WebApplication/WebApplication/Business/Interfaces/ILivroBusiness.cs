using WebApplication.Model;

namespace WebApplication.Business.Interfaces
{
	public interface ILivroBusiness
	{
		Livro Create(Livro livro);
		Livro FindById(int id);
		List<Livro> FindAll();
		Livro Update(Livro livro);
		void Delete(int id);
	}
}
