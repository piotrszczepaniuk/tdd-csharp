using Xunit;

namespace TDD.CSharp.Core.Tests.Exercises.Before._04
{
public class AssertionTest
{
    //1. Write test that use AssertNotNull
    [Fact]
    public void AssertIfNullOrEmpty()
    {

    }

    //2. Write test that use AssertEquals for collections
    [Fact]
    public void AssertArrayEqualsTest()
    {
        var expected = new[] { 2, 5, 7 };
        var actual = new[] { 2, 5, 7 };
    }

    //3. Write test that will use AssertAll and AssertStartsWith to assert all the names start with John
    [Fact]
    public void AssertAllTest()
    {
        var namesCollection = new[]
        {
            "John Smith",
            "John Wayne",
            "John Wick"
        };
    }
}
}
