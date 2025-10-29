using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Restful.Domain.Entities
{
	[Table("Person")]
	public class Person
	{
		[Key, Column("Id")]
		public int Id { get; set; }

		[Required, MaxLength(80), Column("FirstName", TypeName ="varchar(80)")]
		public string FirstName { get; set; }

		[Required, MaxLength(80), Column("LastName", TypeName = "varchar(80)")]
		public string LastName { get; set; }

		[Required, MaxLength(80), Column("Address", TypeName = "varchar(100)")]
		public string Address { get; set; }

		[Required, MaxLength(80), Column("Gender", TypeName = "varchar(6)")]
		public string Gender { get; set; }
	}
}