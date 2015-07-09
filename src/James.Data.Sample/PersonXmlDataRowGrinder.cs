using System;
using System.IO;
using System.Text;
using System.Xml.Linq;

using James.Data.Grinding;

namespace James.Data.Sample
{
	public class PersonXmlDataRowGrinder : TextFileOutputDataRowGrinder
	{
		private readonly XDocument _xml;

		public PersonXmlDataRowGrinder() : base(@"c:\people.xml")
		{
			_xml = new XDocument(
				new XDeclaration("1.0", "utf-16", "yes"),
				new XElement("people"));
		}

		protected override void OutputRow(dynamic row, StringBuilder output)
		{
			_xml.Root.Add(new XElement("person", 
				new XAttribute("firstName", row.FirstName), 
				new XAttribute("lastName", row.LastName), 
				new XElement("address", 
					new XAttribute("line1", row.Address.Line1), 
					new XAttribute("city", row.Address.City), 
					new XAttribute("state", row.Address.State), 
					new XAttribute("postalCode", row.Address.ZipCode))));
		}

		protected override void OutputAfterGrinding(StringBuilder output)
		{
			var writer = new StringWriter();
			_xml.Save(writer);
			output.Append(writer.GetStringBuilder());
		}
	}
}
