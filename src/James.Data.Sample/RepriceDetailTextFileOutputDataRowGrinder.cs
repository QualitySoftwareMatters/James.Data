using System;
using System.Text;

using James.Data.Grinding;

namespace James.Data.Sample
{
	public class RepriceDetailTextFileOutputDataRowGrinder : TextFileOutputDataRowGrinder
	{
		public RepriceDetailTextFileOutputDataRowGrinder()
			: base(@"c:\Temp\netcharge-rerun-revenuecodes-20150621T0814.csv")
		{
		}

		protected override void BeforeGrinding(StringBuilder output)
		{
			var headers = new[]
			{
				"Client Name",
				"FacilityName",
				"AccountNumber",
				"Created Date",
				"Revenue Code"
			};
			output.AppendLine(String.Join("\t", headers));
		}

		protected override void OutputRow(dynamic row, StringBuilder output)
		{
			foreach (var procedure in row.Json.Visit.Procedures)
			{
				output.AppendFormat("{0}\t{1}\t{2}\t{3}\t{4}\r\n",
					row.ClientName,
					row.FacilityName,
					row.AccountNumber,
					row.CreatedDate,
					procedure.RevenueCode);
			}
		}
	}
}