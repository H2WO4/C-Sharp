using Microsoft.VisualStudio.TestTools.UnitTesting;

using Vache.Models;
using Vache.Utils;


namespace Vache.Tests;

[TestClass]
public class CycleTest
{
    [TestMethod]
    public void CycleTest1()
    {
        int[] testArray   = { 1, 2, 3, 4, 5 };
        int[] resultArray = { 3, 4, 5, 1, 2 };

        int[] cycledArray = testArray.Cycle(2).ToArray();

        for (var i = 0; i < 5; i++)
            Assert.AreEqual(resultArray[i], cycledArray[i]);
    }

    [TestMethod]
    public void CycleTest2()
    {
        int[] testArray =
        {
            7, 2, 1, 8, 1,
            2, 0
        };
        int[] resultArray =
        {
            2, 0, 7, 2, 1,
            8, 1
        };

        int[] cycledArray = testArray.Cycle(5).ToArray();

        for (var i = 0; i < 5; i++)
            Assert.AreEqual(resultArray[i], cycledArray[i]);
    }

    [TestMethod]
    public void CycleTestFail()
    {
        // int[] testArray = Array.Empty<int>();
        var testArray = new Point2[] { new(2, 3) };
        var _ = testArray.Cycle(4);
        // Assert.ThrowsException<ArgumentOutOfRangeException>(() => { });
    }
}