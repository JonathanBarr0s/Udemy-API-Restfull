using Microsoft.EntityFrameworkCore;

namespace API_Restful.Data.Context
{
	public static class DatabaseConfig
	{
		public static IServiceCollection AddDatabaseConfiguration(
			this IServiceCollection services, IConfiguration configuration)
		{
			var connectionString = configuration["MSSQLServerSQLConnection:MSSQLServerSQLConnectionString"];

			if (string.IsNullOrEmpty(connectionString))
			{
				throw new ArgumentNullException("Connection string 'MSSQLServerSQLConnectionString' not found.");
			}

			services.AddDbContext<AppDbContext>(options =>
				options.UseSqlServer(connectionString));
			return services;
		}
	}
}