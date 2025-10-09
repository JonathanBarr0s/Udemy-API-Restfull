using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication.Migrations
{
	/// <inheritdoc />
	public partial class PopularPessoa : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql(
				"INSERT INTO Pessoa(Nome, Sobrenome, Endereco, Sexo)" +
				"Values('Camila', 'Almeida', 'Rua das Laranjeiras, 245 - Rio de Janeiro/RJ', 'Feminino')"
				);

			migrationBuilder.Sql(
				"INSERT INTO Pessoa(Nome, Sobrenome, Endereco, Sexo)" +
				"Values('Jonathan', 'Freire', 'Av. Paulista, 100 - São Paulo/SP', 'Masculino')"
				);

			migrationBuilder.Sql(
				"INSERT INTO Pessoa(Nome, Sobrenome, Endereco, Sexo)" +
				"Values('Pedro', 'Soares', 'Rua Verde, 789 - Belo Horizonte/MG', 'Masculino')"
				);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql("DELETE FROM Pessoa");
		}
	}
}
