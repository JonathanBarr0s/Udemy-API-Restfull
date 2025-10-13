using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication.Model.Base;

namespace WebApplication.Model
{
	[Table("Pessoa")]
	public class Pessoa : BaseEntity
	{
		[StringLength(80, ErrorMessage = "O tamanho máximo é de 80 caracteres.")]
		[Required(ErrorMessage = "O campo Nome não pode estar vazio.")]
		[Display(Name = "Nome")]
		public string Nome { get; set; }

		[StringLength(80, ErrorMessage = "O tamanho máximo é de 80 caracteres.")]
		[Required(ErrorMessage = "O campo Sobrenome não pode estar vazio.")]
		[Display(Name = "Sobrenome")]
		public string Sobrenome { get; set; }

		[StringLength(80, ErrorMessage = "O tamanho máximo é de 80 caracteres.")]
		[Required(ErrorMessage = "O campo Endereço não pode estar vazio.")]
		[Display(Name = "Endereco")]
		public string Endereco { get; set; }

		[StringLength(10, ErrorMessage = "O tamanho máximo é de 10 caracteres.")]
		[Required(ErrorMessage = "O campo Sexo não pode estar vazio.")]
		[Display(Name = "Sexo")]
		public string Sexo { get; set; }
	}
}
