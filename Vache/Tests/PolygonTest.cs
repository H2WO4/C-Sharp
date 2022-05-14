using Microsoft.VisualStudio.TestTools.UnitTesting;

using Vache.Interfaces;
using Vache.Models;


namespace Vache.Tests;

[TestClass]
public class FieldTest
{
    [TestMethod]
    public void FieldFullTest1()
    {
        var field = new Field(new Point2[] { new(-1, 1), new(-1, -1), new(1, -1), new(1, 1) });

        double   area      = field.Area;
        I_Point2 cog       = field.CenterOfGravity;
        bool     inPolygon = field.IsPointInside(cog);

        Assert.AreEqual(4, area, Program.TOLERANCE);
        Assert.AreEqual(0, cog.X, Program.TOLERANCE);
        Assert.AreEqual(0, cog.Y, Program.TOLERANCE);
        Assert.IsTrue(inPolygon);
    }

    [TestMethod]
    public void FieldFullTest2()
    {
        var field = new Field(new Point2[] { new(-16.6, -20), new(-12, -18), new(-11, -16), new(-15, -15) });

        double   area      = field.Area;
        I_Point2 cog       = field.CenterOfGravity;
        bool     inPolygon = field.IsPointInside(cog);

        Assert.AreEqual(14.4, area, Program.TOLERANCE);
        Assert.AreEqual(-13.95, cog.X, Program.TOLERANCE);
        Assert.AreEqual(-17.25, cog.Y, Program.TOLERANCE);
        Assert.IsTrue(inPolygon);
    }

    [TestMethod]
    public void FieldFullTest3()
    {
        var field = new Field(new Point2[] { new(-1, -1), new(2, 3), new(5, -1), new(2, 2) });

        double   area      = field.Area;
        I_Point2 cog       = field.CenterOfGravity;
        bool     inPolygon = field.IsPointInside(cog);

        Assert.AreEqual(-3, area, Program.TOLERANCE);
        Assert.AreEqual(2, cog.X, Program.TOLERANCE);
        Assert.AreEqual(1.333, cog.Y, Program.TOLERANCE);
        Assert.IsFalse(inPolygon);
    }

    [TestMethod]
    public void FieldFullTest4()
    {
        var field = new Field(new Point2[] { new(-1, -1), new(-1, -2), new(2, -5), new(4, 1), new(2, -4) });

        double   area      = field.Area;
        I_Point2 cog       = field.CenterOfGravity;
        bool     inPolygon = field.IsPointInside(cog);

        Assert.AreEqual(4, area, Program.TOLERANCE);
        Assert.AreEqual(1.04, cog.X, Program.TOLERANCE);
        Assert.AreEqual(-2.91, cog.Y, Program.TOLERANCE);
        Assert.IsFalse(inPolygon);
    }

    [TestMethod]
    public void FieldFullTestThrows()
    {
        Assert.ThrowsException<ArgumentException>(() => new Field(Array.Empty<Point2>()));
    }

    [TestMethod]
    public void FieldParseTestSuccess()
    {
        Field field = Polygon.Parse("(-1, 1), (-1, -1), (1, -1), (1, 1)") as Field;

        double   area      = field.Area;
        I_Point2 cog       = field.CenterOfGravity;
        bool     inPolygon = field.IsPointInside(cog);

        Assert.AreEqual(4, area, Program.TOLERANCE);
        Assert.AreEqual(0, cog.X, Program.TOLERANCE);
        Assert.AreEqual(0, cog.Y, Program.TOLERANCE);
        Assert.IsTrue(inPolygon);
    }

    [TestMethod]
    public void FieldParseTestThrows()
    {
        Assert.ThrowsException<ArgumentException>(() => Field.Parse("(-1, 1..), (-1, -1), (1, -1), (1, 1)"));
    }

    [TestMethod]
    public void FieldTryParseTestSuccess()
    {
        Assert.IsTrue(Field.TryParse("(-1, 1), (-1, -1), (1, -1), (1, 1)", out Field? field));
        Assert.IsNotNull(field);

        double   area      = field.Area;
        I_Point2 cog       = field.CenterOfGravity;
        bool     inPolygon = field.IsPointInside(cog);

        Assert.AreEqual(4, area, Program.TOLERANCE);
        Assert.AreEqual(0, cog.X, Program.TOLERANCE);
        Assert.AreEqual(0, cog.Y, Program.TOLERANCE);
        Assert.IsTrue(inPolygon);
    }
    
    [TestMethod]
    public void FieldTryParseFail1()
    {
        Assert.IsFalse(Field.TryParse("(-1), (-1, -1), (1, -1), (1, 1)", out Field? field));
        Assert.IsNull(field);
    }
    
    [TestMethod]
    public void FieldTryParseFail2()
    {
        Assert.IsFalse(Field.TryParse("(-1, 1), (-1 -1), (1, -1), (1, 1)", out Field? field));
        Assert.IsNull(field);
    }
    
    [TestMethod]
    public void FieldTryParseFail3()
    {
        Assert.IsFalse(Field.TryParse("(-1, 1), (-1, -1), (b, -1), (1, 1)", out Field? field));
        Assert.IsNull(field);
    }
}