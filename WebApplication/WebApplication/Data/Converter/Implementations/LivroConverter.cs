using WebApplication.Data.Converter.Contract;
using WebApplication.Data.VO;
using WebApplication.Model;

namespace WebApplication.Data.Converter.Implementations
{
	public class LivroConverter : IParser<LivroVO, Livro>, IParser<Livro, LivroVO>
	{
		public Livro Parse(LivroVO origin)
		{
			if (origin == null)
				return null;

			return new Livro
			{
				Id = origin.Id,
				Titulo = origin.Titulo,
				Autor = origin.Autor,
				DataDeLancamento = origin.DataDeLancamento,
				Preco = origin.Preco,
			};
		}

		public List<Livro> Parse(List<LivroVO> origin)
		{
			if (origin == null)
				return null;

			return origin.Select(item => Parse(item)).ToList();
		}

		public LivroVO Parse(Livro origin)
		{
			if (origin == null)
				return null;

			return new LivroVO
			{
				Id = origin.Id,
				Titulo = origin.Titulo,
				Autor = origin.Autor,
				DataDeLancamento = origin.DataDeLancamento,
				Preco = origin.Preco,
			};
		}

		public List<LivroVO> Parse(List<Livro> origin)
		{
			if (origin == null)
				return null;

			return origin.Select(item => Parse(item)).ToList();
		}
	}
}