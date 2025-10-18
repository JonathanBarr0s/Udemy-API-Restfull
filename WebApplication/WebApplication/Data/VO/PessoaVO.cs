using System.Text.Json.Serialization;
using WebApplication.Hypermedia;
using WebApplication.Hypermedia.Abstract;

namespace WebApplication.Data.VO
{
	public class PessoaVO : ISupportsHyperMedia
	{
		[JsonPropertyName("Id")]
		public int Id { get; set; }

		[JsonPropertyName("Name")]
		public string Nome { get; set; }
		
		[JsonPropertyName("Last Name")]
		public string Sobrenome { get; set; }

		[JsonPropertyName("Address")]
		public string Endereco { get; set; }

		[JsonPropertyName("Sex")]
		public string Sexo { get; set; }
		public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
	}
}
