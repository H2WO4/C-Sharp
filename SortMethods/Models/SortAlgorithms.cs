namespace SortMethods.Models
{
	public class SortAlgorithms
	{
		public static IEnumerable<T> BubbleSort<T>(IEnumerable<T> input)
			where T : IComparable
		{
			int length = input.Count();
			bool isSorted = false;

			var temp = input.ToArray();

			for (var i = length-1; i > 0 && !isSorted; i--)
			{
				isSorted = true;
				for (var j = 0; j < i; j++)
					if (temp[j].CompareTo(temp[j+1]) == 1)
					{
						(temp[j], temp[j+1]) = (temp[j+1], temp[j]);
						isSorted = false;
					}
			}

			return temp;
		}
	}
}