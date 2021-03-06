using Microsoft.VisualStudio.TestTools.UnitTesting;

using Vache.Models;


namespace Vache.Tests;

[TestClass]
public class PolygonTest
{
    [TestMethod]
    public void PolygonFull1()
    {
        var polygon = new Polygon2(new Point2[] { new(-1, 1), new(-1, -1), new(1, -1), new(1, 1) });

        double area      = polygon.Area;
        Point2 cog       = polygon.CenterOfGravity;
        bool   inPolygon = polygon.IsPointInside(cog);

        Assert.AreEqual(4, area, Program.TOLERANCE);
        Assert.AreEqual(0, cog.X, Program.TOLERANCE);
        Assert.AreEqual(0, cog.Y, Program.TOLERANCE);
        Assert.IsTrue(inPolygon);
    }

    [TestMethod]
    public void PolygonFull2()
    {
        var polygon = new Polygon2(new Point2[] { new(-16.6, -20), new(-12, -18), new(-11, -16), new(-15, -15) });

        double area      = polygon.Area;
        Point2 cog       = polygon.CenterOfGravity;
        bool   inPolygon = polygon.IsPointInside(cog);

        Assert.AreEqual(14.4, area, Program.TOLERANCE);
        Assert.AreEqual(-13.95, cog.X, Program.TOLERANCE);
        Assert.AreEqual(-17.25, cog.Y, Program.TOLERANCE);
        Assert.IsTrue(inPolygon);
    }

    [TestMethod]
    public void PolygonFull3()
    {
        var polygon = new Polygon2(new Point2[] { new(-1, -1), new(2, 3), new(5, -1), new(2, 2) });

        double area      = polygon.Area;
        Point2 cog       = polygon.CenterOfGravity;
        bool   inPolygon = polygon.IsPointInside(cog);

        Assert.AreEqual(-3, area, Program.TOLERANCE);
        Assert.AreEqual(2, cog.X, Program.TOLERANCE);
        Assert.AreEqual(1.333, cog.Y, Program.TOLERANCE);
        Assert.IsFalse(inPolygon);
    }

    [TestMethod]
    public void PolygonFull4()
    {
        var polygon = new Polygon2(new Point2[] { new(-1, -1), new(-1, -2), new(2, -5), new(4, 1), new(2, -4) });

        double area      = polygon.Area;
        Point2 cog       = polygon.CenterOfGravity;
        bool   inPolygon = polygon.IsPointInside(cog);

        Assert.AreEqual(4, area, Program.TOLERANCE);
        Assert.AreEqual(1.04, cog.X, Program.TOLERANCE);
        Assert.AreEqual(-2.91, cog.Y, Program.TOLERANCE);
        Assert.IsFalse(inPolygon);
    }

    [TestMethod]
    public void PolygonZeroPoints()
    {
        Assert.ThrowsException<ArgumentException>(() => new Polygon2(Array.Empty<Point2>()));
    }

    [TestMethod]
    public void PolygonOnePoint()
    {
        Assert.ThrowsException<ArgumentException>(() => new Polygon2(new Point2[] { new(1, 1) }));
    }

    [TestMethod]
    public void PolygonTwoPoints()
    {
        Assert.ThrowsException<ArgumentException>(() => new Polygon2(new Point2[] { new(1, 1), new(2, 2) }));
    }

    [TestMethod]
    public void PolygonNonDistinctPoints()
    {
        Assert.ThrowsException<ArgumentException>(() => new Polygon2(new Point2[] { new(1, 1), new(1, 1), new(1, 1) }));
    }

    [TestMethod]
    public void PolygonParseSuccess()
    {
        Assert.IsTrue(Polygon2.TryParse("(-1, 1), (-1, -1), (1, -1), (1, 1)", out Polygon2? polygon));
        Assert.IsNotNull(polygon);

        double area      = polygon.Area;
        Point2 cog       = polygon.CenterOfGravity;
        bool   inPolygon = polygon.IsPointInside(cog);

        Assert.AreEqual(4, area, Program.TOLERANCE);
        Assert.AreEqual(0, cog.X, Program.TOLERANCE);
        Assert.AreEqual(0, cog.Y, Program.TOLERANCE);
        Assert.IsTrue(inPolygon);
    }

    [TestMethod]
    public void PolygonParseFail1()
    {
        Assert.IsFalse(Polygon2.TryParse("(-1), (-1, -1), (1, -1), (1, 1)", out Polygon2? polygon));
        Assert.IsNull(polygon);
    }

    [TestMethod]
    public void PolygonParseFail2()
    {
        Assert.IsFalse(Polygon2.TryParse("(-1, 1), (-1 -1), (1, -1), (1, 1)", out Polygon2? polygon));
        Assert.IsNull(polygon);
    }

    [TestMethod]
    public void PolygonParseFail3()
    {
        Assert.IsFalse(Polygon2.TryParse("(-1, 1), (-1, -1), (b, -1), (1, 1)", out Polygon2? polygon));
        Assert.IsNull(polygon);
    }

    [TestMethod]
    public void PolygonParseFail4()
    {
        Assert.IsFalse(Polygon2.TryParse("(-1, 1), (-1, -1)", out Polygon2? polygon));
        Assert.IsNull(polygon);
    }

    [TestMethod]
    public void PolygonString1()
    {
        Polygon2 polygon = new(new Point2[] { new(1, 1), new(-1, 1), new(-1, -1) });

        Assert.AreEqual("(1, 1), (-1, 1), (-1, -1)", polygon.ToString());
    }

    [TestMethod]
    public void PolygonString2()
    {
        Polygon2 polygon = new(new Point2[] { new(0, -6), new(2.5, 8.4), new(-1.2, 99) });

        Assert.AreEqual("(0, -6), (2.5, 8.4), (-1.2, 99)", polygon.ToString());
    }

    [TestMethod]
    public void PolygonEquals1()
    {
        Polygon2 poly1 = new(new Point2[] { new(1, 1), new(-1, 1), new(-1, -1) }),
                 poly2 = new(new Point2[] { new(1, 1), new(-1, 1), new(-1, -1) });

        Assert.IsTrue(poly1 == poly2);
    }

    [TestMethod]
    public void PolygonEquals2()
    {
        Polygon2 poly1 = new(new Point2[] { new(1, 1), new(-1, 1), new(-1, -1) }),
                 poly2 = new(new Point2[] { new(1, 2), new(-1, 1), new(-1, -1) });

        Assert.IsTrue(poly1 != poly2);
    }

    [TestMethod]
    public void PolygonEquals3()
    {
        Polygon2? poly1 = new(new Point2[] { new(1, 1), new(-1, 1), new(-1, -1) }),
                  poly2 = null;

        Assert.IsFalse(poly1 == poly2);
    }

    [TestMethod]
    public void PolygonEquals4()
    {
        Polygon2? poly1 = new(new Point2[] { new(1, 1), new(-1, 1), new(-1, -1) }),
                  poly2 = null;

        Assert.IsTrue(poly1 != poly2);
    }

    [TestMethod]
    public void PolygonEquals5()
    {
        Polygon2? poly1 = null,
                  poly2 = null;

        Assert.IsTrue(poly1 == poly2);
    }

    [TestMethod]
    public void PolygonEquals6()
    {
        Polygon2? poly1 = null,
                  poly2 = null;

        Assert.IsFalse(poly1 != poly2);
    }

    [TestMethod]
    public void PolygonEquals7()
    {
        Polygon2 poly  = new(new Point2[] { new(1, 1), new(-1, 1), new(-1, -1) });
        Point2[] array = { new(1, 1), new(-1, 1), new(-1, -1) };

        Assert.IsFalse(poly.Equals(array));
    }

    [TestMethod]
    public void PolygonHash()
    {
        Polygon2 poly1 = new(new Point2[] { new(1, 1), new(-1, 1), new(-1, -1) }),
                 poly2 = new(new Point2[] { new(1, 1), new(-1, 1), new(-1, -1) });

        Assert.IsTrue(poly1.GetHashCode() == poly2.GetHashCode());
    }
}