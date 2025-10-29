using API_Restful.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_Restful.Data.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}		

		public DbSet<Person> Persons { get; set; }
	}
}