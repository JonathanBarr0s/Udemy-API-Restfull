using WebApplication.Data.VO;
using WebApplication.Model;

namespace WebApplication.Business.Interfaces
{
	public interface ILivroBusiness
	{
		Task<LivroVO> CreateAsync(LivroVO livro);
		Task<LivroVO> FindByIdAsync(int id);
		Task<IEnumerable<LivroVO>> FindAllAsync();
		Task<LivroVO> UpdateAsync(LivroVO livro);
		Task DeleteAsync(int id);
	}
}
