using WebApplication.Controllers;
using WebApplication.Data.Context;
using WebApplication.Model;

namespace WebApplication.Repository.Implementations
{
	public class PessoaRepositoryImplementation : IPessoaRepository
	{
		private readonly AppDbContext _context;

		public PessoaRepositoryImplementation(AppDbContext context)
		{
			_context = context;
		}

		public Pessoa Create(Pessoa pessoa)
		{
			_context.Pessoa.Add(pessoa);
			_context.SaveChanges();
			return pessoa;
		}

		public void Delete(int id)
		{
			Pessoa pessoa = _context.Pessoa.FirstOrDefault(p => p.Id == id);
			_context.Pessoa.Remove(pessoa);
			_context.SaveChanges();
		}

		public List<Pessoa> FindAll()
		{
			return _context.Pessoa.ToList();
		}

		public Pessoa FindById(int id)
		{
			return _context.Pessoa.FirstOrDefault(p => p.Id == id);
		}

		public Pessoa Update(Pessoa pessoa)
		{
			_context.Pessoa.Update(pessoa);
			_context.SaveChanges();
			return pessoa;
		}
	}
}
