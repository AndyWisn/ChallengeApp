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
            Assert.AreEqual(0, stat.Max);
            Assert.AreEqual(0, stat.Min);
            Assert.AreEqual(0, stat.Average);
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
            Assert.AreEqual(1, stat.Min);
            Assert.AreEqual(3, stat.Max);
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
            Assert.AreEqual(3.33, Math.Round(stat.Average,2));
        }


    }
}