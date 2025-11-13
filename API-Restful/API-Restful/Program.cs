using API_Restful.Business.Implementations;
using API_Restful.Business.Interfaces;
using API_Restful.Data.ContentNegotiation;
using API_Restful.Data.Context;
using API_Restful.Data.Repository.Implementations;
using API_Restful.Data.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddContentNegotiation();

builder.Services.AddDatabaseConfiguration(builder.Configuration);

builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.

if (!app.Environment.IsDevelopment())
{
	app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

var port = Environment.GetEnvironmentVariable("port") ?? "8080";

app.Run($"http://*:{port}");

// app.Run();