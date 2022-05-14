using Microsoft.VisualStudio.TestTools.UnitTesting;

using Vache.Models;
<<<<<<< HEAD
=======
using Vache.Utils;

>>>>>>> 72a638710efddbfb4bebd66286a95c8274f89237

namespace Vache.Tests;

[TestClass]
<<<<<<< HEAD
public class VectorTest
{
    [TestMethod]
    public void VectorParseSuccess()
    {
        Assert.IsTrue(Vector2.TryParse("{1, -1}", out Vector2? vec));
        Assert.IsNotNull(vec);
        
        Assert.AreEqual(1, vec.X);
        Assert.AreEqual(-1, vec.Y);
    }
    
    [TestMethod]
    public void VectorParseFail1()
    {
        Assert.IsFalse(Vector2.TryParse("{1, -1", out Vector2? vec));
        Assert.IsNull(vec);
    }
    
    [TestMethod]
    public void VectorParseFail2()
    {
        Assert.IsFalse(Vector2.TryParse("{1 -1}", out Vector2? vec));
        Assert.IsNull(vec);
    }
    
    [TestMethod]
    public void VectorParseFail3()
    {
        Assert.IsFalse(Vector2.TryParse("{A, -1}", out Vector2? vec));
        Assert.IsNull(vec);
    }
    
    [TestMethod]
    public void VectorString1()
    {
        Vector2 vec = new(1, 2);

        Assert.AreEqual("{1, 2}", vec.ToString());
    }

    [TestMethod]
    public void VectorString2()
    {
        Vector2 vec = new(-1, 2.5);

        Assert.AreEqual("{-1, 2.5}", vec.ToString());
    }
    
    [TestMethod]
    public void VectorAdd1()
    {
        Vector2 vec1 = new(1, 1),
                vec2 = new(2, 3),
                res  = new(3, 4);

        Assert.AreEqual(res, vec1 + vec2);
    }

    [TestMethod]
    public void VectorAdd2()
    {
        Vector2 vec1 = new(0, 5),
                vec2 = new(-3, -7),
                res  = new(-3, -2);

        Assert.AreEqual(res, vec1 + vec2);
    }

    [TestMethod]
    public void VectorSubtract1()
    {
        Vector2 vec1 = new(2, 3),
                vec2 = new(1, 1),
                res  = new(1, 2);

        Assert.AreEqual(res, vec1 - vec2);
    }

    [TestMethod]
    public void VectorSubtract2()
    {
        Vector2 vec1 = new(-3, 2),
                vec2 = new(-6, 4),
                res  = new(3, -2);

        Assert.AreEqual(res, vec1 - vec2);
    }

    [TestMethod]
    public void VectorNegate()
    {
        Vector2 vec = new(-3, 2),
                res = new(3, -2);

        Assert.AreEqual(res, -vec);
    }

    [TestMethod]
    public void VectorMultiply1()
    {
        Vector2 vec = new(1, 2),
                res = new(2, 4);

        Assert.AreEqual(res, vec * 2);
    }

    [TestMethod]
    public void VectorMultiply2()
    {
        Vector2 vec = new(1, -2),
                res = new(-3, 6);

        Assert.AreEqual(res, vec * -3);
    }

    [TestMethod]
    public void VectorDivide1()
    {
        Vector2 vec = new(1, 2),
                res = new(0.5, 1);

        Assert.AreEqual(res, vec / 2);
    }

    [TestMethod]
    public void VectorDivide2()
    {
        Vector2 vec = new(1, -2),
                res = new(-0.25, 0.5);

        Assert.AreEqual(res, vec / -4);
    }

    [TestMethod]
    public void VectorEqual1()
    {
        Vector2 vec1 = new(1, 2),
                vec2 = new(1, 2);

        Assert.IsTrue(vec1 == vec2);
    }

    [TestMethod]
    public void VectorEqual2()
    {
        Vector2 vec1 = new(1, 2),
                vec2 = new(-1, 2);

        Assert.IsTrue(vec1 != vec2);
    }

    [TestMethod]
    public void VectorEqual3()
    {
        Vector2? vec1 = new(1, 2),
                 vec2 = null;

        Assert.IsFalse(vec1 == vec2);
    }
    
    [TestMethod]
    public void VectorEqual4()
    {
        Vector2? vec1 = new(1, 2),
                 vec2 = null;

        Assert.IsTrue(vec1 != vec2);
    }
    
    [TestMethod]
    public void VectorEqual5()
    {
        Vector2? vec1 = null,
                 vec2 = null;

        Assert.IsTrue(vec1 == vec2);
    }
    
    [TestMethod]
    public void VectorEqual6()
    {
        Vector2? vec1 = null,
                 vec2 = null;

        Assert.IsFalse(vec1 != vec2);
    }

    [TestMethod]
    public void VectorEqual7()
    {
        Vector2 vec = new(1, 2);
        Point2  pnt = new(1, 2);

        // ReSharper disable once SuspiciousTypeConversion.Global
        Assert.IsFalse(vec.Equals(pnt));
    }

    [TestMethod]
    public void VectorHash()
    {
        Vector2 vec = new(1, 2),
                res = new(1, 2);

        Assert.IsTrue(vec.GetHashCode() == res.GetHashCode());
=======
public class CycleTest
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
>>>>>>> 72a638710efddbfb4bebd66286a95c8274f89237
    }
}