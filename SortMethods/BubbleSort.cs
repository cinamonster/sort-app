using System;
using System.Collections.Generic;

namespace SortApp {
	public class BubbleSort<T> : ISortable<T> where T : IComparable {
		public IList<T> Sort(IList<T> values) {
			if(values.Count < 2 ) {
				return values;
			}

			for(var j = 0; j < values.Count - 1; j++) {
				var swapped = false;
				var i = 0;
				while(i < values.Count - j - 1) {
					if(values[i].CompareTo(values[i + 1]) > 0) {
						var tmp = values[i];
 						values[i] = values[i + 1];
						values[i + 1] = tmp;
 						swapped = true;
					}
 					i++;
				}
				if(!swapped) {
					break;
				}
			}
			return values;
		}
	}
}