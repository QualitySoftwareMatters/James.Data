using System.Collections.Generic;

namespace James.Data.Grinding
{
	public interface IDataRowProvider
	{
		IEnumerable<dynamic> GetRows();
	}
}