using Microsoft.VisualStudio.TestTools.UnitTesting;

using Vache.Utils;


namespace Vache.Tests;

[TestClass]
public class PairsTest
{
    [TestMethod]
    public void PairsTest1()
    {
        int[]        testArray   = { 1, 2, 3, 4, 5 };
        (int, int)[] resultArray = { (1, 2), (2, 3), (3, 4), (4, 5), };

        (int, int)[] cycledArray = testArray.Pairs().ToArray();

        for (var i = 0; i < resultArray.Length; i++)
            Assert.AreEqual(resultArray[i], cycledArray[i]);
    }

    [TestMethod]
    public void PairsTest2()
    {
        int[] testArray =
        {
            7, 2, 1, 8, 1,
            2, 0,
        };
        (int, int)[] resultArray =
        {
            (7, 2), (2, 1), (1, 8), (8, 1), (1, 2),
            (2, 0), (0, 7),
        };

        (int, int)[] cycledArray = testArray.Pairs(true).ToArray();

        for (var i = 0; i < cycledArray.Length; i++)
            Assert.AreEqual(resultArray[i], cycledArray[i]);
    }

    [TestMethod]
    public void PairsTestEmpty()
    {
        int[]        testArray   = Array.Empty<int>();
        (int, int)[] resultArray = Array.Empty<(int, int)>();

        (int, int)[] cycledArray = testArray.Pairs().ToArray();

        Assert.AreEqual(resultArray, cycledArray);
    }

    [TestMethod]
    public void PairsTestCycleOne()
    {
        int[]        testArray   = { 0 };
        (int, int)[] resultArray = { (0, 0) };

        (int, int)[] cycledArray = testArray.Pairs(true).ToArray();

        for (var i = 0; i < cycledArray.Length; i++)
            Assert.AreEqual(resultArray[i], cycledArray[i]);
    }
}