using System;
using System.IO;

namespace James.Data.Grinding
{
    public abstract class ConsoleDataRowGrinder : IDataRowGrinder
    {
	    public void BeforeGrinding()
	    {
			Console.WriteLine("Beginning to grind.");
	    }

	    public void GrindRow(dynamic row)
	    {
			GrindRow(row, Console.Out);
	    }

		protected virtual void GrindRow(dynamic row, TextWriter console)
		{ }

	    public void AfterGrinding()
	    {
			Console.WriteLine("Done grinding.");
	    }
    }
}
