using System;
using System.IO;

namespace James.Data.Grinding
{
    public class ConsoleDataRowGrinder : IDataRowGrinder
    {
	    public virtual void BeforeGrinding()
	    {
			Console.WriteLine("Beginning to grind.");
	    }

	    public void GrindRow(dynamic row)
	    {
			GrindRow(row, Console.Out);
	    }

		protected virtual void GrindRow(dynamic row, TextWriter console)
		{ }

	    public virtual void AfterGrinding()
	    {
			Console.WriteLine("Done grinding.");
	    }
    }
}
