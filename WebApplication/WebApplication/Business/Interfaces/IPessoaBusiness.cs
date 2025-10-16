using WebApplication.Data.VO;
using WebApplication.Model;

namespace WebApplication.Business.Interfaces
{
	public interface IPessoaBusiness
	{
		Task<PessoaVO> CreateAsync(PessoaVO pessoa);
		Task<PessoaVO> FindByIdAsync(int id);
		Task<IEnumerable<PessoaVO>> FindAllAsync();
		Task<PessoaVO> UpdateAsync(PessoaVO pessoa);
		Task DeleteAsync(int id);
	}
}
