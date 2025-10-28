using Microsoft.EntityFrameworkCore;

namespace API_Restful.Data.Context
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}		
	}
}