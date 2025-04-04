
using System.Reflection;
using SpacePython.Domain.Catalog;

namespace SpacePython.Domain.Tests;

[RatingTests]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
    }
}

internal class TestMethodAttribute : Attribute
{
}

internal interface IRatingTests
{
    void Cannot_Create_Rating_With_Invalid_Stars();
    void Can_Create_New_Rating();
}

internal class RatingTests : Attribute, IRatingTests
{
}
[TestMethod]
    public void Can_Create_New_Rating()
    {
        var rating = new UserRating(1, "Mike", "Great fit!");
        Assert.AreEqual(1, rating.Stars);
        Assert.AreEqual("Mike", rating.UserName);
        Assert.AreEqual("Great fit!", rating.Review);

    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Cannot_Create_Rating_With_Invalid_Stars()
    {
        var rating = new Rating(0, "Mike", "Great fit!");
    }