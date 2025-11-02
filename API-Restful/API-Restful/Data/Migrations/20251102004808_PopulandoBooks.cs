using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Restful.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoBooks : Migration
    {
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql(@"
                INSERT INTO Book (title, author, price, launch_date) VALUES
                ('Clean Code', 'Robert C. Martin', 49.90, '2008-08-01'),
                ('The Pragmatic Programmer', 'Andrew Hunt, David Thomas', 59.90, '1999-10-30'),
                ('Design Patterns', 'Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides', 79.90, '1994-10-31'),
                ('Refactoring', 'Martin Fowler', 69.90, '1999-07-08'),
                ('Domain-Driven Design', 'Eric Evans', 89.90, '2003-08-30'),
                ('Effective Java', 'Joshua Bloch', 99.90, '2001-05-28'),
                ('Head First Design Patterns', 'Eric Freeman, Elisabeth Robson', 59.90, '2004-10-25'),
                ('Introduction to Algorithms', 'Thomas H. Cormen, Charles E. Leiserson, Ronald L. Rivest, Clifford Stein', 129.90, '2009-07-31'),
                ('Working Effectively with Legacy Code', 'Michael C. Feathers', 49.00, '2004-09-01'),
                ('Code Complete', 'Steve McConnell', 69.90, '2004-06-09');
            ");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
