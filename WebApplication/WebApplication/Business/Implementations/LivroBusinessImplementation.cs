using WebApplication.Business.Interfaces;
using WebApplication.Data.Converter.Implementations;
using WebApplication.Data.VO;
using WebApplication.Model;
using WebApplication.Repository.Generic;

namespace WebApplication.Business.Implementations
{
	public class LivroBusinessImplementation : ILivroBusiness
	{
		private readonly IRepository<Livro> _repository;
		private readonly LivroConverter _livroConverter;

		public LivroBusinessImplementation(IRepository<Livro> repository)
		{
			_repository = repository;
			_livroConverter = new LivroConverter();
		}

		public async Task<LivroVO> CreateAsync(LivroVO livro)
		{
			var livroEntity = _livroConverter.Parse(livro);
			livroEntity = await _repository.CreateAsync(livroEntity);
			return _livroConverter.Parse(livroEntity);
		}

		public async Task DeleteAsync(int id)
		{
			await _repository.DeleteAsync(id);
		}

		public async Task<IEnumerable<LivroVO>> FindAllAsync()
		{
			return _livroConverter.Parse((await _repository.FindAllAsync()).ToList());
		}

		public async Task<LivroVO> FindByIdAsync(int id)
		{
			return _livroConverter.Parse(await _repository.FindByIdAsync(id));
		}

		public async Task<LivroVO> UpdateAsync(LivroVO livro)
		{
			var livroEntity = _livroConverter.Parse(livro);
			livroEntity = await _repository.UpdateAsync(livroEntity);
			return _livroConverter.Parse(livroEntity);
		}
	}
}