using System;
using System.Collections.Generic;

namespace SortApp {

	public class InsertionSort<T> : ISortable<T> where T : IComparable {

		public IList<T> Sort(IList<T> values) {
			for(var j = 1; j < values.Count; j++) {
				var tmp = values[j];
				var i = j - 1;

				while(i >= 0 && values[i].CompareTo(tmp) > 0) {
					values[i + 1] = values[i];
					i--;
				}
				values[i + 1] = tmp;
			}

			return values;
		}
	}
}