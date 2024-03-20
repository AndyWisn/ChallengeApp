namespace ChallengeApp.Tests
{
    public class EmployeeInFileTests
    {
        private const string fileName = "grades.txt";

        [Test]
        public void WhenEmployeeInFileGradesCountIsZeroGetStatistics2ShouldReturnAllZeroes()
        {
            //arrange
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            var employee = new EmployeeInFile();

            // act
            Statistics stat = employee.GetStatistics();

            // assert
            Assert.That(stat.Max, Is.EqualTo(0));
            Assert.That(stat.Min, Is.EqualTo(0));
            Assert.That(stat.Average, Is.EqualTo(0));
        }
        [Test]
        public void WhenEmployeeInFileGetsGradesStatisticsShouldReturnCorrectMinMax()
        {
            //arrange
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            var employee = new EmployeeInFile();
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(3);

            // act
            Statistics stat = employee.GetStatistics();

            // assert
            Assert.That(stat.Min, Is.EqualTo(1));
            Assert.That(stat.Max, Is.EqualTo(3));
        }
        [Test]
        public void WhenEmployeeInFileGetsGradesStatisticsShouldReturnCorrectAverage()
        {
            //arrange
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            var employee = new EmployeeInFile();
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            // act
            Statistics stat = employee.GetStatistics();

            // assert
            Assert.That(Math.Round(stat.Average, 2), Is.EqualTo(3.33));
        }
        [Test]
        public void WhenEmployeeInFileGetsGradeAsLetterReturnCorrectAverage()
        {
            //arrange
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            var employee = new EmployeeInFile();
            employee.AddGrade('A');
            employee.AddGrade('a');
            employee.AddGrade('B');
            employee.AddGrade('b');
            employee.AddGrade('C');
            employee.AddGrade('c');
            employee.AddGrade('D');
            employee.AddGrade('d');
            employee.AddGrade('E');
            employee.AddGrade('e');

            // act
            Statistics stat = employee.GetStatistics();

            // assert
            Assert.That(stat.Average, Is.EqualTo(60));
        }
        [Test]
        public void WhenEmployeeInFileGetsGradeAsLetterReturnCorrectAverageLetter()
        {
            //arrange
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            var employee = new EmployeeInFile();
            employee.AddGrade('A');
            employee.AddGrade('a');
            employee.AddGrade('B');
            employee.AddGrade('b');
            employee.AddGrade('C');
            employee.AddGrade('c');
            employee.AddGrade('D');
            employee.AddGrade('d');
            employee.AddGrade('E');
            employee.AddGrade('e');

            // act
            Statistics stat = employee.GetStatistics();

            // assert
            Assert.That(stat.AverageLetter, Is.EqualTo('B'));
        }
        [Test]
        public void WhenEmployeeInFileGetsGradeAsStringReturnCorrectAverageValue()
        {
            //arrange
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            var employee = new EmployeeInFile();
            employee.AddGrade("6");       //100
            employee.AddGrade("6-");      //95
            employee.AddGrade("-6");      //95

            employee.AddGrade("5+");      //85
            employee.AddGrade("+5");      //85
            employee.AddGrade("5");       //80
            employee.AddGrade("-5");      //75
            employee.AddGrade("5-");      //75

            employee.AddGrade("4+");      //65
            employee.AddGrade("+4");      //65
            employee.AddGrade("4");       //60
            employee.AddGrade("-4");      //55
            employee.AddGrade("4-");      //55

            employee.AddGrade("3+");      //45
            employee.AddGrade("+3");      //45
            employee.AddGrade("3");       //40
            employee.AddGrade("-3");      //35
            employee.AddGrade("3-");      //35

            employee.AddGrade("2+");      //25
            employee.AddGrade("+2");      //25
            employee.AddGrade("2");       //20
            employee.AddGrade("-2");      //15
            employee.AddGrade("2-");      //15

            employee.AddGrade("1+");      //5
            employee.AddGrade("+1");      //5
            employee.AddGrade("1");       //0
            
            // act
            Statistics stat = employee.GetStatistics();

            // assert
            Assert.That(stat.Average, Is.EqualTo(50));
        }
    }
}
