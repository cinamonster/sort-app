using System;
using System.Collections.Generic;

namespace SortApp {
	public class CocktailSort<T> : ISortable<T> where T : IComparable {
		public IList<T> Sort(IList<T> values) {
			var left = 0;
			var right = values.Count - 1;

			while(left < right) {
				for(var i = left; i < right; i++) {
					if(values[i].CompareTo(values[i + 1]) > 0) {
						Swap(values, i, i + 1);
					}                   
				}
				right--;

				for(var i = right; i > left; i--) {
					if(values[i].CompareTo(values[i - 1]) < 0) {
						Swap(values, i, i - 1);
					}
				}
				left++;
			}

			return values;
		}

		private void Swap(IList<T> values, int i, int j) {
			var tmp = values[i];
			values[i] = values[j];
			values[j] = tmp;
		}
	}
}