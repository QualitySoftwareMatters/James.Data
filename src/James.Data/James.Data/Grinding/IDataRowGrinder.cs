namespace James.Data.Grinding
{
	public interface IDataRowGrinder
	{
		void BeforeGrinding();
		void GrindRow(dynamic row);
		void AfterGrinding();
	}
}