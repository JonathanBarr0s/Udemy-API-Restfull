using WebApplication.Business.Interfaces;
using WebApplication.Model;
using WebApplication.Repository.Generic;

namespace WebApplication.Business.Implementations
{
	public class LivroBusinessImplementation : ILivroBusiness
	{
		private readonly IRepository<Livro> _repository;

		public LivroBusinessImplementation(IRepository<Livro> repository)
		{
			_repository = repository;
		}

		public async Task<Livro> CreateAsync(Livro livro)
		{
			return await _repository.CreateAsync(livro);
		}

		public async Task DeleteAsync(int id)
		{
			await _repository.DeleteAsync(id);
		}

		public async Task<IEnumerable<Livro>> FindAllAsync()
		{
			return await _repository.FindAllAsync();
		}

		public async Task<Livro> FindByIdAsync(int id)
		{
			return await _repository.FindByIdAsync(id);
		}

		public async Task<Livro> UpdateAsync(Livro livro)
		{
			return await _repository.UpdateAsync(livro);
		}
	}
}