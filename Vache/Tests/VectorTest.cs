using Microsoft.VisualStudio.TestTools.UnitTesting;

using Vache.Models;

namespace Vache.Tests;

[TestClass]
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
    }
}