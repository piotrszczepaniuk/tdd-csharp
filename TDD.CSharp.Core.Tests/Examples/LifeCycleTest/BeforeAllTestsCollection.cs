using Xunit;


namespace TDD.CSharp.Core.Tests.Examples.LifeCycleTest
{
    [CollectionDefinition("BeforeAll collection")]
    public class BeforeAllCollection : ICollectionFixture<BeforeAllTestsFixture> { }
}
