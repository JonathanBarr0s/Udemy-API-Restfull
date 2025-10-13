using System.ComponentModel.DataAnnotations;

namespace WebApplication.Model.Base
{
	public class BaseEntity
	{
		[Key]
		public int Id { get; set; }
	}
}
