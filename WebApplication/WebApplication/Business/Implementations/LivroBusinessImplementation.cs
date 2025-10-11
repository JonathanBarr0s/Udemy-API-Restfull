using WebApplication.Business.Interfaces;
using WebApplication.Controllers;
using WebApplication.Data.Context;
using WebApplication.Model;
using WebApplication.Repository.Interfaces;

namespace WebApplication.Business.Implementations
{
	public class LivroBusinessImplementation : ILivroBusiness
	{
		private readonly ILivroRepository _livroRepository;

		public LivroBusinessImplementation(ILivroRepository repository)
		{
			_livroRepository = repository;
		}

		public Livro Create(Livro livro)
		{
			return _livroRepository.Create(livro);
		}

		public void Delete(int id)
		{
			_livroRepository.Delete(id);
		}

		public List<Livro> FindAll()
		{
			return _livroRepository.FindAll();
		}

		public Livro FindById(int id)
		{
			return _livroRepository.FindById(id);
		}

		public Livro Update(Livro pessoa)
		{
			return _livroRepository.Update(pessoa);
		}
	}
}
