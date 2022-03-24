using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortMethods.Models;

namespace SortMethods.Tests
{
	[TestClass]
	public class TestSortMethods
	{
		[TestMethod]
		public void Test1()
		{
			int[] input = { 3, 2, 1 };
			int[] expected = { 1, 2, 3 };
			int[] output = SortAlgorithms.BubbleSort(input).ToArray();

			for (var i = 0; i < 3; i++)
				Assert.AreEqual(expected[i], output[i]);
		}

		[TestMethod]
		public void Test2()
		{
			string[] input = { "salut", "bonjour", "hello" };
			string[] expected = { "bonjour", "hello", "salut" };
			string[] output = SortAlgorithms.BubbleSort(input).ToArray();

			for (var i = 0; i < 3; i++)
				Assert.AreEqual(expected[i], output[i]);
		}
	}
}