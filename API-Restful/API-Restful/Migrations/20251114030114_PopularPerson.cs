using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Restful.Migrations
{
    /// <inheritdoc />
    public partial class PopularPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.Sql(@"
                INSERT INTO ""Person"" (""FirstName"", ""LastName"", ""Address"", ""Gender"") VALUES
                ('Lucas', 'Silva', 'Rua das Flores, 123', 'Male'),
                ('Ana', 'Oliveira', 'Avenida Brasil, 456', 'Female'),
                ('Pedro', 'Santos', 'Rua 7 de Setembro, 78', 'Male'),
                ('Mariana', 'Costa', 'Rua da Paz, 34', 'Female'),
                ('Rafael', 'Pereira', 'Alameda Santos, 210', 'Male'),
                ('Carla', 'Moura', 'Rua das Acácias, 56', 'Female'),
                ('Bruno', 'Almeida', 'Avenida Rio Branco, 98', 'Male'),
                ('Fernanda', 'Lima', 'Rua do Sol, 12', 'Female'),
                ('Gustavo', 'Rocha', 'Travessa do Carmo, 77', 'Male'),
                ('Patrícia', 'Fernandes', 'Rua das Palmeiras, 44', 'Female');
            ");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
