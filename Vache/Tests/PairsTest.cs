using Microsoft.VisualStudio.TestTools.UnitTesting;

<<<<<<< HEAD
=======
using Vache.Models;
>>>>>>> 72a638710efddbfb4bebd66286a95c8274f89237
using Vache.Utils;


namespace Vache.Tests;

[TestClass]
<<<<<<< HEAD
public class PairsTest
{
    [TestMethod]
    public void PairsTest1()
    {
        int[]        testArray   = { 1, 2, 3, 4, 5 };
        (int, int)[] resultArray = { (1, 2), (2, 3), (3, 4), (4, 5), };

        (int, int)[] cycledArray = testArray.Pairs().ToArray();

        for (var i = 0; i < resultArray.Length; i++)
=======
public class CycleTest
{
    [TestMethod]
    public void CycleTest1()
    {
        int[] testArray   = { 1, 2, 3, 4, 5 };
        int[] resultArray = { 3, 4, 5, 1, 2 };

        int[] cycledArray = testArray.Cycle(2).ToArray();

        for (var i = 0; i < 5; i++)
>>>>>>> 72a638710efddbfb4bebd66286a95c8274f89237
            Assert.AreEqual(resultArray[i], cycledArray[i]);
    }

    [TestMethod]
<<<<<<< HEAD
    public void PairsTest2()
=======
    public void CycleTest2()
>>>>>>> 72a638710efddbfb4bebd66286a95c8274f89237
    {
        int[] testArray =
        {
            7, 2, 1, 8, 1,
<<<<<<< HEAD
            2, 0,
        };
        (int, int)[] resultArray =
        {
            (7, 2), (2, 1), (1, 8), (8, 1), (1, 2),
            (2, 0), (0, 7),
        };

        (int, int)[] cycledArray = testArray.Pairs(true).ToArray();

        for (var i = 0; i < cycledArray.Length; i++)
=======
            2, 0
        };
        int[] resultArray =
        {
            2, 0, 7, 2, 1,
            8, 1
        };

        int[] cycledArray = testArray.Cycle(5).ToArray();

        for (var i = 0; i < 5; i++)
>>>>>>> 72a638710efddbfb4bebd66286a95c8274f89237
            Assert.AreEqual(resultArray[i], cycledArray[i]);
    }

    [TestMethod]
<<<<<<< HEAD
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
=======
    public void CycleTestFail()
    {
        // int[] testArray = Array.Empty<int>();
        var testArray = new Point2[] { new(2, 3) };
        var _ = testArray.Cycle(4);
        // Assert.ThrowsException<ArgumentOutOfRangeException>(() => { });
>>>>>>> 72a638710efddbfb4bebd66286a95c8274f89237
    }
}