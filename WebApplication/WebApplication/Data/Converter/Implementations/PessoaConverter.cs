using WebApplication.Data.Converter.Contract;
using WebApplication.Data.VO;
using WebApplication.Model;

namespace WebApplication.Data.Converter.Implementations
{
	public class PessoaConverter : IParser<PessoaVO, Pessoa>, IParser<Pessoa, PessoaVO>
	{
		public Pessoa Parse(PessoaVO origin)
		{
			if (origin == null)
				return null;

			return new Pessoa
			{
				Id = origin.Id,
				Nome = origin.Nome,
				Sobrenome = origin.Sobrenome,
				Endereco = origin.Endereco,
				Sexo = origin.Sexo,
			};
		}

		public List<Pessoa> Parse(List<PessoaVO> origin)
		{
			if (origin == null)
				return null;

			return origin.Select(item => Parse(item)).ToList();
		}

		public PessoaVO Parse(Pessoa origin)
		{
			if (origin == null)
				return null;

			return new PessoaVO
			{
				Id = origin.Id,
				Nome = origin.Nome,
				Sobrenome = origin.Sobrenome,
				Endereco = origin.Endereco,
				Sexo = origin.Sexo,
			};
		}

		public List<PessoaVO> Parse(List<Pessoa> origin)
		{
			if (origin == null)
				return null;

			return origin.Select(item => Parse(item)).ToList();
		}
	}
}
