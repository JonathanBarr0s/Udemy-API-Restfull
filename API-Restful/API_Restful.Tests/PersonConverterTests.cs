using API_Restful.Data.Converter.Implementations;
using API_Restful.Data.DTO;
using API_Restful.Domain.Entities;
using FluentAssertions;

namespace API_Restful.Tests
{
	public class PersonConverterTests
	{
		private readonly PersonConverter _converter;

		public PersonConverterTests()
		{
			_converter = new PersonConverter();
		}

		[Fact]
		public void PersonDTO_To_Person()
		{
			var personDTO = new PersonDTO()
			{
				Id = 1,
				FirstName = "Jonathan",
				LastName = "Barros",
				Address = "São Paulo",
				Gender = "Male"
			};

			var expectedPerson = new Person()
			{
				Id = 1,
				FirstName = "Jonathan",
				LastName = "Barros",
				Address = "São Paulo",
				Gender = "Male"
			};

			var test = _converter.Parse(personDTO);

			test.Should().NotBeNull();
			test.Should().BeEquivalentTo(expectedPerson);
		}

		[Fact]
		public void PersonDTONull_To_Person()
		{
			PersonDTO personDTO = null;

			var test = _converter.Parse(personDTO);

			test.Should().BeNull();
		}

		[Fact]
		public void Person_To_PersonDTO()
		{
			var person = new Person()
			{
				Id = 1,
				FirstName = "Jonathan",
				LastName = "Barros",
				Address = "São Paulo",
				Gender = "Male"
			};

			var expectedPersonDTO = new PersonDTO()
			{
				Id = 1,
				FirstName = "Jonathan",
				LastName = "Barros",
				Address = "São Paulo",
				Gender = "Male"
			};

			var test = _converter.Parse(person);

			test.Should().NotBeNull();
			test.Should().BeEquivalentTo(expectedPersonDTO);
		}

		[Fact]
		public void PersonNull_To_PersonDTO()
		{
			Person person = null;

			var test = _converter.Parse(person);
			test.Should().BeNull();
		}

		[Fact]
		public void PersonDTOList_To_PersonList()
		{
			var listPersonDTO = new List<PersonDTO>()
			{
				new PersonDTO() {

					Id = 1,
					FirstName = "Jonathan",
					LastName = "Barros",
					Address = "São Paulo",
					Gender = "Male"
				},

				new PersonDTO() {

					Id = 2,
					FirstName = "Gabriel",
					LastName = "Silva",
					Address = "São Paulo",
					Gender = "Male"
				}
			};

			var expectedListPerson = new List<Person>()
			{
				new Person() {

					Id = 1,
					FirstName = "Jonathan",
					LastName = "Barros",
					Address = "São Paulo",
					Gender = "Male"
				},

				new Person() {

					Id = 2,
					FirstName = "Gabriel",
					LastName = "Silva",
					Address = "São Paulo",
					Gender = "Male"
				}
			};

			var test = _converter.ParseList(listPersonDTO);

			test.Should().NotBeNullOrEmpty();
			test.Should().HaveCount(2);
			test.Should().BeEquivalentTo(expectedListPerson);
		}

		[Fact]
		public void PersonDTONullList_To_PersonList()
		{
			List<PersonDTO> listPersonDTO = null;

			var test = _converter.ParseList(listPersonDTO);

			test.Should().BeNull();
		}

		[Fact]
		public void PersonList_To_PersonDTOList()
		{
			var listPerson = new List<Person>()
			{
				new Person() {

					Id = 1,
					FirstName = "Jonathan",
					LastName = "Barros",
					Address = "São Paulo",
					Gender = "Male"
				},

				new Person() {

					Id = 2,
					FirstName = "Gabriel",
					LastName = "Silva",
					Address = "São Paulo",
					Gender = "Male"
				}
			};

			var expectedListPersonDTO = new List<PersonDTO>()
			{
				new PersonDTO() {

					Id = 1,
					FirstName = "Jonathan",
					LastName = "Barros",
					Address = "São Paulo",
					Gender = "Male"
				},

				new PersonDTO() {

					Id = 2,
					FirstName = "Gabriel",
					LastName = "Silva",
					Address = "São Paulo",
					Gender = "Male"
				}
			};

			var test = _converter.ParseList(listPerson);

			test.Should().NotBeNullOrEmpty();
			test.Should().HaveCount(2);
			test.Should().BeEquivalentTo(expectedListPersonDTO);
		}

		[Fact]
		public void PersonNullList_To_PersonDTOList()
		{
			List<Person> listPerson = null;

			var test = _converter.ParseList(listPerson);

			test.Should().BeNull();
		}
	}
}