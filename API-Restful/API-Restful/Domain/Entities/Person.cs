using API_Restful.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Restful.Domain.Entities
{
	[Table("Person")]
	public class Person : BaseEntity
	{
		[Required, MaxLength(80), Column("FirstName", TypeName ="varchar(80)")]
		public string FirstName { get; set; }

		[Required, MaxLength(80), Column("LastName", TypeName = "varchar(80)")]
		public string LastName { get; set; }

		[Required, MaxLength(100), Column("Address", TypeName = "varchar(100)")]
		public string Address { get; set; }

		[Required, MaxLength(6), Column("Gender", TypeName = "varchar(6)")]
		public string Gender { get; set; }
	}
}