using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenEmployeeCollectScoresShouldReturnCorrectSum()
        {

            //arrange
            var Employee = new Employee("Andrzej", "Wiœniewski", 46);
            Employee.AddScore(5);
            Employee.SubScore(5);
            Employee.AddScore(6);
            Employee.SubScore(6);


            // act
            int result = Employee.Result;

            // assert
            Assert.AreEqual(0, result);

        }


    }
}