using Microsoft.EntityFrameworkCore;
using WebApplication.Model;

namespace WebApplication.Data.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Pessoa> Pessoa { get; set; }
	}
}
