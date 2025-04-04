
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

internal class RatingTests : Attribute
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
[ExpectedExceptio(typeof(ArgumentException))]{
    var rating = new RatingTests(0, "Mike", "Great fit!");
}