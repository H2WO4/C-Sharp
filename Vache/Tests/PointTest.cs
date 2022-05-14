<<<<<<< HEAD
﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

using Vache.Models;


namespace Vache.Tests;

[TestClass]
public class PointTest
{
    [TestMethod]
    public void PointTranslate1()
    {
        Point2  pnt = new(1, 2);
        Vector2 vec = new(2, 3);
        Point2  res = new(3, 5);

        Assert.AreEqual(res, pnt.Translate(vec));
    }

    [TestMethod]
    public void PointTranslate2()
    {
        Point2  pnt = new(4.5, -2);
        Vector2 vec = new(-3, 0);
        Point2  res = new(1.5, -2);

        Assert.AreEqual(res, pnt.Translate(vec));
    }

    [TestMethod]
    public void PointParseSuccess()
    {
        Assert.IsTrue(Point2.TryParse("(1, 2)", out Point2? point));
        Assert.IsNotNull(point);
    }

    [TestMethod]
    public void PointParseFail1()
    {
        Assert.IsFalse(Point2.TryParse("(1, 2", out Point2? point));
        Assert.IsNull(point);
    }

    [TestMethod]
    public void PointParseFail2()
    {
        Assert.IsFalse(Point2.TryParse("(1 2)", out Point2? point));
        Assert.IsNull(point);
    }

    [TestMethod]
    public void PointParseFail3()
    {
        Assert.IsFalse(Point2.TryParse("(A, 2)", out Point2? point));
        Assert.IsNull(point);
    }

    [TestMethod]
    public void PointString1()
    {
        Point2 pnt = new(1, 2);

        Assert.AreEqual("(1, 2)", pnt.ToString());
    }

    [TestMethod]
    public void PointString2()
    {
        Point2 pnt = new(-1, 2.5);

        Assert.AreEqual("(-1, 2.5)", pnt.ToString());
    }

    [TestMethod]
    public void PointEqual1()
    {
        Point2 pnt1 = new(1, 2),
               pnt2 = new(1, 2);

        Assert.IsTrue(pnt1 == pnt2);
    }

    [TestMethod]
    public void PointEqual2()
    {
        Point2 pnt1 = new(1, 2),
               pnt2 = new(-1, 2);

        Assert.IsTrue(pnt1 != pnt2);
    }

    [TestMethod]
    public void PointEqual3()
    {
        Point2? vec1 = new(1, 2),
                vec2 = null;

        Assert.IsFalse(vec1 == vec2);
    }

    [TestMethod]
    public void PointEqual4()
    {
        Point2? vec1 = new(1, 2),
                vec2 = null;

        Assert.IsTrue(vec1 != vec2);
    }

    [TestMethod]
    public void PointEqual5()
    {
        Point2? vec1 = null,
                vec2 = null;

        Assert.IsTrue(vec1 == vec2);
    }

    [TestMethod]
    public void PointEqual6()
    {
        Point2? vec1 = null,
                vec2 = null;

        Assert.IsFalse(vec1 != vec2);
    }

    [TestMethod]
    public void PointEqual7()
    {
        Point2  pnt = new(1, 2);
        Vector2 vec = new(1, 2);

        // ReSharper disable once SuspiciousTypeConversion.Global
        Assert.IsFalse(pnt.Equals(vec));
    }

    [TestMethod]
    public void PointHash()
    {
        Point2 pnt = new(1, 2),
               res = new(1, 2);

        Assert.IsTrue(pnt.GetHashCode() == res.GetHashCode());
    }
=======
﻿namespace Vache.Tests;

public class PointTest
{
    
>>>>>>> 72a638710efddbfb4bebd66286a95c8274f89237
}