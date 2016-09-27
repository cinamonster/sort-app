using System;
using System.Collections.Generic;

namespace SortApp
{
	public class Program
	{
		public static void Main()
		{
			while(true) {
				IList<int> values = new List<int> { 4, 5, 7, 8, 2, 9, 0, 11, 5, 87, 1 };
				ShowValues(values);

				var sortMethod = SortFactory<int>.SelectSortMethod();
				if(sortMethod == null) {
					break;
				}

				sortMethod.Sort(values);
				ShowValues(values, "Sorted values: ");
				Console.WriteLine();
			}
		}

		public static void ShowValues<T>(IList<T> values, string comment = null) {
			Console.WriteLine(comment ?? "Values: ");
			for(var i = 0; i < values.Count; i++) {
				Console.Write($"{values[i].ToString()} ");
			}
			Console.WriteLine();
		}
	}
}