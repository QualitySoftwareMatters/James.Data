using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using James.Data.Grinding;

using Newtonsoft.Json;

namespace James.Data.Sample
{
	public class RepriceDetailRowProvider : IDataRowProvider
	{
		public IEnumerable<object> GetRows()
		{
			var rows = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "repriceDetail.csv"));

			var index = 0;

			return (
				from row in rows
				where index++ != 0
				select row.Split('\t')
				into columns
				select new Row()
				{
					ClientName = columns[0],
					FacilityName = columns[1],
					AccountNumber = columns[2],
					CreatedDate = DateTime.Parse(columns[4]),
					Json = JsonConvert.DeserializeObject(columns[7])
				});
		}

		public class Row
		{
			public string ClientName { get; set; }
			public string FacilityName { get; set; }
			public string AccountNumber { get; set; }
			public dynamic Json { get; set; }
			public DateTime CreatedDate { get; set; }
		}
	}
}