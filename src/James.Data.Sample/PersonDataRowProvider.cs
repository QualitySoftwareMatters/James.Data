using System.Collections.Generic;

using James.Data.Grinding;

namespace James.Data.Sample
{
	public class PersonDataRowProvider : IDataRowProvider
	{
		public IEnumerable<dynamic> GetRows()
		{
			return new[]
			{
				new Person
				{
					FirstName = "Todd",
					LastName = "Meinershagen",
					Address = new Address() {Line1 = "1850 Countryside Dr", City = "Frisco", State = "TX", ZipCode = "75034"},
				},
				new Person
				{
					FirstName = "Raj",
					LastName = "Patel",
					Address = new Address() {Line1 = "1800 MyUniverse Ct", City = "Richardson", State = "TX", ZipCode = "75025"}
				}
			};
		}

		public class Person
		{
			public string FirstName { get; set; }
			public string LastName { get; set; }
			public Address Address { get; set; }
		}

		public class Address
		{
			public string Line1 { get; set; }
			public string City { get; set; }
			public string State { get; set; }
			public string ZipCode { get; set; }
		}
	}
}
