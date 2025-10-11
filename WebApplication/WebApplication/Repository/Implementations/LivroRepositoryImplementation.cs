using WebApplication.Controllers;
using WebApplication.Data.Context;
using WebApplication.Model;
using WebApplication.Repository.Interfaces;

namespace WebApplication.Repository.Implementations
{
	public class LivroRepositoryImplementation : ILivroRepository
	{
		private readonly AppDbContext _context;

		public LivroRepositoryImplementation(AppDbContext context)
		{
			_context = context;
		}

		public Livro Create(Livro livro)
		{
			_context.Livro.Add(livro);
			_context.SaveChanges();
			return livro;
		}

		public void Delete(int id)
		{
			Livro livro = _context.Livro.FirstOrDefault(p => p.Id == id);
			_context.Livro.Remove(livro);
			_context.SaveChanges();
		}

		public List<Livro> FindAll()
		{
			return _context.Livro.ToList();
		}

		public Livro FindById(int id)
		{
			return _context.Livro.FirstOrDefault(p => p.Id == id);
		}

		public Livro Update(Livro livro)
		{
			_context.Livro.Update(livro);
			_context.SaveChanges();
			return livro;
		}
	}
}
