namespace James.Data.Grinding
{
	public class GrindingEngine
	{
		private readonly IDataRowProvider _provider;
		private readonly IDataRowGrinder[] _grinders;

		public GrindingEngine(IDataRowProvider provider, params IDataRowGrinder[] grinders)
		{
			_provider = provider;
			_grinders = grinders;
		}

		public void Grind()
		{
			foreach (var grinder in _grinders)
			{
				grinder.BeforeGrinding();
			}

			var rows = _provider.GetRows();

			foreach (var row in rows)
			{
				foreach (var grinder in _grinders)
				{
					grinder.GrindRow(row);
				}
			}

			foreach (var grinder in _grinders)
			{
				grinder.AfterGrinding();
			}
		}
	}
}