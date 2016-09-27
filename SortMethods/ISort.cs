using System;
using System.Collections.Generic;

namespace SortApp {
	public interface ISortable<T> where T : IComparable {
		IList<T> Sort(IList<T> values);
	}
}