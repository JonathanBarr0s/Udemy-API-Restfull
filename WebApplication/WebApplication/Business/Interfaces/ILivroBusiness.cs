using WebApplication.Model;

namespace WebApplication.Business.Interfaces
{
	public interface ILivroBusiness
	{
		Task<Livro> CreateAsync(Livro livro);
		Task<Livro> FindByIdAsync(int id);
		Task<IEnumerable<Livro>> FindAllAsync();
		Task<Livro> UpdateAsync(Livro livro);
		Task DeleteAsync(int id);
	}
}
