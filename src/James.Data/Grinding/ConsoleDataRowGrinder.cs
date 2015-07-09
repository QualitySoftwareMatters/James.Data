using System;
using System.IO;

namespace James.Data.Grinding
{
    public class ConsoleDataRowGrinder : IDataRowGrinder
    {
	    public void BeforeGrinding()
	    {
			Console.WriteLine("Beginning to grind.");
		    BeforeGrinding(Console.Out);
	    }

		protected virtual void BeforeGrinding(TextWriter console)
		{ }

	    public void GrindRow(dynamic row)
	    {
			GrindRow(row, Console.Out);
	    }

		protected virtual void GrindRow(dynamic row, TextWriter console)
		{ }

	    public void AfterGrinding()
	    {
			AfterGrinding(Console.Out);
			Console.WriteLine("Done grinding.");
	    }

		protected virtual void AfterGrinding(TextWriter console)
		{ }
    }
}
