using WebApplication.Controllers;
using WebApplication.Data.Context;
using WebApplication.Model;
using WebApplication.Repository;

namespace WebApplication.Business.Implementations
{
	public class PessoaBusinessImplementation : IPessoaBusiness
	{
		private readonly IPessoaRepository _pessoaRepository;

		public PessoaBusinessImplementation(IPessoaRepository repository)
		{
			_pessoaRepository = repository;
		}

		public Pessoa Create(Pessoa pessoa)
		{
			return _pessoaRepository.Create(pessoa);
		}

		public void Delete(int id)
		{
			_pessoaRepository.Delete(id);
		}

		public List<Pessoa> FindAll()
		{
			return _pessoaRepository.FindAll();
		}

		public Pessoa FindById(int id)
		{
			return _pessoaRepository.FindById(id);
		}

		public Pessoa Update(Pessoa pessoa)
		{
			return _pessoaRepository.Update(pessoa);
		}
	}
}
