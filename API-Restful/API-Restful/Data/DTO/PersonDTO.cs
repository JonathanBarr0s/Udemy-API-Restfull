using System.Text.Json.Serialization;

namespace API_Restful.Data.DTO
{
	public class PersonDTO
	{
		[JsonPropertyName("Código:")]
		[JsonPropertyOrder(1)]
		public int Id { get; set; }

		[JsonPropertyName("Nome:")]
		[JsonPropertyOrder(2)]
		public string FirstName { get; set; }

		[JsonPropertyName("Sobrenome:")]
		[JsonPropertyOrder(3)]
		public string LastName { get; set; }

		[JsonPropertyName("Endereço:")]
		[JsonPropertyOrder(5)]
		public string Address { get; set; }

		[JsonPropertyName("Gênero:")]
		[JsonPropertyOrder(4)]
		public string Gender { get; set; }
	}
}