using Microsoft.EntityFrameworkCore;
using WebApplication.Business.Implementations;
using WebApplication.Business.Interfaces;
using WebApplication.Data.Context;
using WebApplication.Repository.Implementations;
using WebApplication.Repository.Interfaces;

var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddApiVersioning();

builder.Services.AddControllers();

builder.Services.AddScoped<IPessoaBusiness, PessoaBusinessImplementation>();

builder.Services.AddScoped<IPessoaRepository, PessoaRepositoryImplementation>();

builder.Services.AddScoped<ILivroBusiness, LivroBusinessImplementation>();

builder.Services.AddScoped<ILivroRepository, LivroRepositoryImplementation>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
	var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
	db.Database.Migrate();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
