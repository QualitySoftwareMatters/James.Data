using System;
using System.Text;

using James.Data.Grinding;

namespace James.Data.Sample
{
	public class PersonDataRowGrinder : TextFileOutputDataRowGrinder
	{
		public PersonDataRowGrinder()
			: base(@"c:\person.csv")
		{
		}

		protected override void BeforeGrinding(StringBuilder output)
		{
			var headers = new[]
			{
				"First Name",
				"Last Name",
				"Address Line 1",
				"City",
				"State",
				"ZipCode"
			};
			output.AppendLine(String.Join("\t", headers));
		}

		protected override void OutputRow(dynamic row, StringBuilder output)
		{
			output.AppendFormat("{0}\t{1}\t{2}\t{3}\t{4}\t{5}" + Environment.NewLine,
					row.FirstName,
					row.LastName,
					row.Address.Line1,
					row.Address.City,
					row.Address.State,
					row.Address.ZipCode);
		}
	}
}
