using Microsoft.VisualStudio.TestTools.UnitTesting;

using Vache.Utils;


namespace Vache.Tests;

[TestClass]
public class RegexTest
{
    [TestMethod]
    public void NumberRegex1()
    {
        Assert.IsTrue(Consts.NumberRe.IsMatch("42"));
    }

    [TestMethod]
    public void NumberRegex2()
    {
        Assert.IsTrue(Consts.NumberRe.IsMatch("69.420"));
    }

    [TestMethod]
    public void NumberRegex3()
    {
        Assert.IsTrue(Consts.NumberRe.IsMatch(".666"));
    }

    [TestMethod]
    public void NumberRegex4()
    {
        Assert.IsTrue(Consts.NumberRe.IsMatch("0."));
    }

    [TestMethod]
    public void NumberRegex5()
    {
        Assert.IsTrue(Consts.NumberRe.IsMatch("1e1"));
    }

    [TestMethod]
    public void NumberRegex6()
    {
        Assert.IsTrue(Consts.NumberRe.IsMatch("-18"));
    }

    [TestMethod]
    public void NumberRegex7()
    {
        Assert.IsTrue(Consts.NumberRe.IsMatch("-1e-1"));
    }

    [TestMethod]
    public void NumberRegex8()
    {
        Assert.IsTrue(Consts.NumberRe.IsMatch("+4"));
    }

    [TestMethod]
    public void NumberRegex9()
    {
        Assert.IsFalse(Consts.NumberRe.IsMatch("A"));
    }

    [TestMethod]
    public void NumberRegex10()
    {
        Assert.IsFalse(Consts.NumberRe.IsMatch("."));
    }

    [TestMethod]
    public void NumberRegex11()
    {
        Assert.IsFalse(Consts.NumberRe.IsMatch("e"));
    }
}