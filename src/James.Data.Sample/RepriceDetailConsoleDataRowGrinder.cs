using System;
using System.IO;

using James.Data.Grinding;

namespace James.Data.Sample
{
	public class RepriceDetailConsoleDataRowGrinder : ConsoleDataRowGrinder
	{
		protected override void GrindRow(dynamic row, TextWriter console)
		{
			foreach (var procedure in row.Json.Visit.Procedures)
			{
				Console.WriteLine(procedure.RevenueCode.ToString());
			}
		}
	}
}