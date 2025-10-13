using WebApplication.Business.Interfaces;
using WebApplication.Model;
using WebApplication.Repository.Generic;

namespace WebApplication.Business.Implementations
{
	public class PessoaBusinessImplementation : IPessoaBusiness
	{
		private readonly IRepository<Pessoa> _repository;

		public PessoaBusinessImplementation(IRepository<Pessoa> repository)
		{
			_repository = repository;
		}

		public async Task<Pessoa> CreateAsync(Pessoa pessoa)
		{
			return await _repository.CreateAsync(pessoa);
		}

		public async Task DeleteAsync(int id)
		{
			await _repository.DeleteAsync(id);
		}

		public async Task<IEnumerable<Pessoa>> FindAllAsync()
		{
			return await _repository.FindAllAsync();
		}

		public async Task<Pessoa> FindByIdAsync(int id)
		{
			return await _repository.FindByIdAsync(id);
		}

		public async Task<Pessoa> UpdateAsync(Pessoa pessoa)
		{
			return await _repository.UpdateAsync(pessoa);
		}
	}
}
