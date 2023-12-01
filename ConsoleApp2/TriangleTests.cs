using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleLibrary;
using TriangleEntity;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void TestClassifyTriangle_AcuteTriangle()
    {
        Triangle triangle = new Triangle(3.0, 3.0, 3.0);

        TriangleType triangleType = TriangleClassifier.ClassifyTriangle(triangle);

        Assert.AreEqual(TriangleType.AcuteTriangle, triangleType);
    }

    [TestMethod]
    public void TestClassifyTriangle_RightTriangle()
    {
        Triangle triangle = new Triangle(6.0, 8.0, 10.0);

        TriangleType triangleType = TriangleClassifier.ClassifyTriangle(triangle);

        Assert.AreEqual(TriangleType.RightTriangle, triangleType);
    }

    [TestMethod]
    public void TestClassifyTriangle_ObtuseTriangle()
    {
        Triangle triangle = new Triangle(2.0, 12.0, 13.0);

        TriangleType triangleType = TriangleClassifier.ClassifyTriangle(triangle);

        Assert.AreEqual(TriangleType.ObtuseTriangle, triangleType);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestClassifyTriangle_InvalidTriangle()
    {
        Triangle triangle = new Triangle(1.0, 1.0, 3.0);
        TriangleType triangleType = TriangleClassifier.ClassifyTriangle(triangle);
    }
}



