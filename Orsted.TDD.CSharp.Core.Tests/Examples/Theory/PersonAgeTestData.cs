using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TDD.CSharp.Core.Tests.Examples.Theory
{
    public class PersonAgeTestData
    {
        public static IEnumerable<object[]> InternalTestData 
        {
            get
            {
                yield return new object[] { 1, false };
                yield return new object[] { 8, false };
                yield return new object[] { 17, false };
                yield return new object[] { 18, true };
                yield return new object[] { 20, true };
                yield return new object[] { 21, true };
                yield return new object[] { 22, true };
                yield return new object[] { 65, true };
                yield return new object[] { 100, true };

            }
        }

        public static IEnumerable<object[]> ExternalTestData
        {
            get 
            {
                var lines = File.ReadAllLines(@"Examples\Theory\TestData.csv");

                return lines.Select(line => line.Split(',').Cast<object>().ToArray()).ToList();
            }
        }
    }

    
}
