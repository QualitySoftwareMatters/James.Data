using System;

using James.Data.Grinding;

namespace James.Data.Sample
{
	class Program
	{
		static void Main(string[] args)
		{
			var provider = new PersonDataRowProvider();
			IDataRowGrinder[] grinders =
			{
				new PersonConsoleDataRowGrinder(), 
				new PersonDataRowGrinder()
			};
			var engine = new GrindingEngine(provider, grinders);
			engine.Grind();

			Console.WriteLine("Hit ENTER to end...");
			Console.ReadLine();
		}
	}
}
