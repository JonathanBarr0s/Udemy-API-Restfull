using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication.Model.Base;

namespace WebApplication.Model
{
	public class Livro : BaseEntity
	{
		[StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres.")]
		[Required(ErrorMessage = "O campo Título é obrigatório.")]
		[Display(Name = "Título")]
		public string Titulo { get; set; }

		[StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres.")]
		[Required(ErrorMessage = "O campo Autor é obrigatório.")]
		public string Autor { get; set; }

		[Required(ErrorMessage = "O campo Data de Lançamento é obrigatório.")]
		[Display(Name = "Data de Lançamento")]
		public DateTime DataDeLancamento { get; set; }

		[Column(TypeName = "decimal(38,2)")]
		[Required(ErrorMessage = "O campo Preço é obrigatório.")]
		[Display(Name = "Preço")]
		public decimal Preco { get; set; }
	}
}
