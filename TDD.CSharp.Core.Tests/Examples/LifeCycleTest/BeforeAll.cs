using System;

namespace TDD.CSharp.Core.Tests.Examples.LifeCycleTest
{
    public class BeforeAll
    {
        public Guid Id { get; } = Guid.NewGuid();
     
        public BeforeAll()
        {
            
        }
    }
}