using System.IO;

using James.Data.Grinding;

namespace James.Data.Sample
{
	public class PersonConsoleDataRowGrinder : ConsoleDataRowGrinder
	{
		protected override void GrindRow(dynamic row, System.IO.TextWriter console)
		{
			console.WriteLine("Person:  {0} {1}", row.FirstName, row.LastName);
		}

		protected override void AfterGrinding(TextWriter console)
		{
			console.WriteLine(@"Output file(s) are located at:  c:\people.csv, c:\people.xml");
		}
	}
}
