namespace ChallengeApp.Tests
{
    public class Tests
    {   [Test]
        public void WhenGradesCountIsZeroGetStatistics2ShouldReturnAllZeroes()
        {
            //arrange
            var Employee = new Employee("Andrzej", "Wiœniewski");

            // act
            Statistics stat = Employee.GetStatistics();

            // assert
            Assert.That(stat.Max,Is.EqualTo(0));
            Assert.That(stat.Min, Is.EqualTo(0));
            Assert.That(stat.Average, Is.EqualTo(0));
        }

        [Test]
        public void WhenEmployeeGetsGradesStatisticsShouldReturnCorrectMinMax()
        {
            //arrange
            var Employee = new Employee("Andrzej", "Wiœniewski");
            Employee.AddGrade(1);
            Employee.AddGrade(2);
            Employee.AddGrade(3);

            // act
            Statistics stat = Employee.GetStatistics();

            // assert
            Assert.That(stat.Min, Is.EqualTo(1));
            Assert.That(stat.Max, Is.EqualTo(3));
        }

        [Test]

        public void WhenEmployeeGetsGradesStatisticsShouldReturnCorrectAverage()
        {
            //arrange
            var Employee = new Employee("Andrzej", "Wiœniewski");
            Employee.AddGrade(2);
            Employee.AddGrade(2);
            Employee.AddGrade(6);

            // act
            Statistics stat = Employee.GetStatistics();

            // assert
            Assert.That(Math.Round(stat.Average, 2), Is.EqualTo(3.33));
            
        }


    }
}