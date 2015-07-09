using System.IO;
using System.Text;

namespace James.Data.Grinding
{
	public abstract class TextFileOutputDataRowGrinder : IDataRowGrinder
	{
		private readonly string _outputFilePath;
		private readonly StringBuilder _output = new StringBuilder();

		protected TextFileOutputDataRowGrinder(string outputFilePath)
		{
			_outputFilePath = outputFilePath;
		}

		public void BeforeGrinding()
		{
			BeforeGrinding(_output);
		}

		protected virtual void BeforeGrinding(StringBuilder output)
		{ }

		public void GrindRow(dynamic row)
		{
			OutputRow(row, _output);
		}

		protected abstract void OutputRow(dynamic row, StringBuilder output);

		public void AfterGrinding()
		{
			AfterGrinding(_output);
			File.WriteAllText(_outputFilePath, _output.ToString());
		}

		protected virtual void AfterGrinding(StringBuilder output)
		{ }
	}
}