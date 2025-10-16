using WebApplication.Business.Interfaces;
using WebApplication.Data.Converter.Implementations;
using WebApplication.Data.VO;
using WebApplication.Model;
using WebApplication.Repository.Generic;

namespace WebApplication.Business.Implementations
{
	public class PessoaBusinessImplementation : IPessoaBusiness
	{
		private readonly IRepository<Pessoa> _repository;
		private readonly PessoaConverter _pessoaConverter;

		public PessoaBusinessImplementation(IRepository<Pessoa> repository)
		{
			_repository = repository;
			_pessoaConverter = new PessoaConverter();
		}

		public async Task<PessoaVO> CreateAsync(PessoaVO pessoa)
		{
			var pessoaEntity = _pessoaConverter.Parse(pessoa);
			pessoaEntity = await _repository.CreateAsync(pessoaEntity);
			return _pessoaConverter.Parse(pessoaEntity);
		}

		public async Task DeleteAsync(int id)
		{
			await _repository.DeleteAsync(id);
		}

		public async Task<IEnumerable<PessoaVO>> FindAllAsync()
		{
			return _pessoaConverter.Parse((await _repository.FindAllAsync()).ToList());
		}

		public async Task<PessoaVO> FindByIdAsync(int id)
		{
			return _pessoaConverter.Parse(await _repository.FindByIdAsync(id));
		}

		public async Task<PessoaVO> UpdateAsync(PessoaVO pessoa)
		{
			var pessoaEntity = _pessoaConverter.Parse(pessoa);
			pessoaEntity = await _repository.UpdateAsync(pessoaEntity);
			return _pessoaConverter.Parse(pessoaEntity);
		}
	}
}
