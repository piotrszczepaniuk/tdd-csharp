using TDD.CSharp.Core.Examples.Theory;
using Xunit;
namespace TDD.CSharp.Core.Tests.Examples.Theory
{
    public class MemberDataTest
    {
        [Theory]
        [MemberData(nameof(PersonAgeTestData.InternalTestData), MemberType = typeof(PersonAgeTestData))]
        public void ShouldValidatePerson1IsAdult(int age, bool expectedResult)
        {
            //Given
            Person1 person = new Person1(age);
            //When
            bool isAdult = person.IsAdult();
            //Then
            Assert.Equal(expectedResult, isAdult);
        }

        [Theory(Skip = "This theory is skipped")]
        [MemberData(nameof(PersonAgeTestData.InternalTestData), MemberType = typeof(PersonAgeTestData))]
        public void ShouldValidatePerson2IsAdult(int age, bool expectedResult)
        {
            //Given
            Person2 person = new Person2(age);
            //When
            bool isAdult = person.IsAdult();
            //Then
            Assert.Equal(expectedResult, isAdult);
        }

        [Theory]
        [MemberData(nameof(PersonAgeTestData.ExternalTestData), MemberType = typeof(PersonAgeTestData))]
        public void ShouldValidatePerson1IsAdultFromFile(int age, bool expectedResult)
        {
            //Given
            Person2 person = new Person2(age);
            //When
            bool isAdult = person.IsAdult();
            //Then
            Assert.Equal(expectedResult, isAdult);
        }


    }
}
