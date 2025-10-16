namespace WebApplication.Data.VO
{
	public class LivroVO
	{
		public int Id { get; set; }
		public string Titulo { get; set; }
		public string Autor { get; set; }
		public DateTime DataDeLancamento { get; set; }
		public decimal Preco { get; set; }
	}
}
