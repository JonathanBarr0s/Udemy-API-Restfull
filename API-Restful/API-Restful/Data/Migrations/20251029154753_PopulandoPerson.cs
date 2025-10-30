using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Restful.Migrations
{
	/// <inheritdoc />
	public partial class PopulandoPerson : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.InsertData(
			table: "Person",
			columns: new[] { "FirstName", "LastName", "Address", "Gender" },
			values: new object[,]
			{
				{ "Lucas", "Almeida", "Rua das Flores, 123 - São Paulo/SP", "Male" },
				{ "Mariana", "Silva", "Av. Brasil, 456 - Rio de Janeiro/RJ", "Female" },
				{ "Rafael", "Santos", "Rua das Palmeiras, 78 - Belo Horizonte/MG", "Male" },
				{ "Carla", "Oliveira", "Rua dos Jasmins, 90 - Curitiba/PR", "Female" },
				{ "Bruno", "Costa", "Av. Paulista, 1000 - São Paulo/SP", "Male" },
				{ "Fernanda", "Souza", "Rua Aroeiras, 22 - Porto Alegre/RS", "Female" },
				{ "Thiago", "Pereira", "Rua Bahia, 65 - Recife/PE", "Male" },
				{ "Amanda", "Ribeiro", "Rua Rio Negro, 50 - Salvador/BA", "Female" },
				{ "Gustavo", "Fernandes", "Av. das Américas, 800 - Fortaleza/CE", "Male" },
				{ "Patrícia", "Melo", "Rua das Acácias, 12 - Florianópolis/SC", "Female" }
			});
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{

		}
	}
}
