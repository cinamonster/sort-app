using System;

namespace SortApp {

	public static class SortFactory<T> where T : IComparable {
		
		public static ISortable<T> SelectSortMethod() {
			Console.WriteLine("Choose sort algorithm: 0 - Bubble Sort, 1 - Cocktail Sort, " +
			"2 - Insertion Sort.\nPress X for exit");
			var sortNum = Console.ReadLine();

			switch(sortNum.Replace(" ", String.Empty)) {
				case "0": return new BubbleSort<T>();
				case "1": return new CocktailSort<T>();
				case "2": return new InsertionSort<T>();
				case "X": return null;
				default: { 
					Console.WriteLine($"Can't find the algorithm number {sortNum}. Try once more.");
					return SelectSortMethod();
				}
			}
		}
	}
}