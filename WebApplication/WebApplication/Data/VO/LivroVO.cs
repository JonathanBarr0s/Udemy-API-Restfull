using System.Text.Json.Serialization;

namespace WebApplication.Data.VO
{
	public class LivroVO
	{
		[JsonPropertyName("Id")]
		public int Id { get; set; }

		[JsonPropertyName("Title")]
		public string Titulo { get; set; }

		[JsonPropertyName("Author")]
		public string Autor { get; set; }

		[JsonPropertyName("Date of birth")]
		public DateTime DataDeLancamento { get; set; }

		[JsonPropertyName("Price")]
		public decimal Preco { get; set; }
	}
}
