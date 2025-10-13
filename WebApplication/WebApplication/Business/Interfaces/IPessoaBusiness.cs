using WebApplication.Model;

namespace WebApplication.Business.Interfaces
{
	public interface IPessoaBusiness
	{
		Task<Pessoa> CreateAsync(Pessoa pessoa);
		Task<Pessoa> FindByIdAsync(int id);
		Task<IEnumerable<Pessoa>> FindAllAsync();
		Task<Pessoa> UpdateAsync(Pessoa pessoa);
		Task DeleteAsync(int id);
	}
}
