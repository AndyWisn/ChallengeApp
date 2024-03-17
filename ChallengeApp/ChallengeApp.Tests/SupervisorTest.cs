namespace ChallengeApp.Tests
{
    public class SupervisorTests
    {
        [Test]
        public void WhenSupervisorGradesCountIsZeroGetStatistics2ShouldReturnAllZeroes()
        {
            //arrange
            var Supervisor = new Supervisor();

            // act
            Statistics stat = Supervisor.GetStatistics();

            // assert
            Assert.That(stat.Max, Is.EqualTo(0));
            Assert.That(stat.Min, Is.EqualTo(0));
            Assert.That(stat.Average, Is.EqualTo(0));
        }
        [Test]
        public void WhenSupervisorGetsGradesStatisticsShouldReturnCorrectMinMax()
        {
            //arrange
            var Supervisor = new Supervisor();
            Supervisor.AddGrade(1);
            Supervisor.AddGrade(2);
            Supervisor.AddGrade(3);

            // act
            Statistics stat = Supervisor.GetStatistics();

            // assert
            Assert.That(stat.Min, Is.EqualTo(1));
            Assert.That(stat.Max, Is.EqualTo(3));
        }
        [Test]
        public void WhenSupervisorGetsGradesStatisticsShouldReturnCorrectAverage()
        {
            //arrange
            var Supervisor = new Supervisor();
            Supervisor.AddGrade(2);
            Supervisor.AddGrade(2);
            Supervisor.AddGrade(6);

            // act
            Statistics stat = Supervisor.GetStatistics();

            // assert
            Assert.That(Math.Round(stat.Average, 2), Is.EqualTo(3.33));
        }
        [Test]
        public void WhenSupervisorGetsGradeAsLetterReturnCorrectAverage()
        {
            //arrange
            var Supervisor = new Supervisor();
            Supervisor.AddGrade('A');
            Supervisor.AddGrade('a');
            Supervisor.AddGrade('B');
            Supervisor.AddGrade('b');
            Supervisor.AddGrade('C');
            Supervisor.AddGrade('c');
            Supervisor.AddGrade('D');
            Supervisor.AddGrade('d');
            Supervisor.AddGrade('E');
            Supervisor.AddGrade('e');

            // act
            Statistics stat = Supervisor.GetStatistics();

            // assert
            Assert.That(stat.Average, Is.EqualTo(60));
        }
        [Test]
        public void WhenSupervisorGetsGradeAsLetterReturnCorrectAverageLetter()
        {
            //arrange
            var Supervisor = new Supervisor();
            Supervisor.AddGrade('A');
            Supervisor.AddGrade('a');
            Supervisor.AddGrade('B');
            Supervisor.AddGrade('b');
            Supervisor.AddGrade('C');
            Supervisor.AddGrade('c');
            Supervisor.AddGrade('D');
            Supervisor.AddGrade('d');
            Supervisor.AddGrade('E');
            Supervisor.AddGrade('e');

            // act
            Statistics stat = Supervisor.GetStatistics();

            // assert
            Assert.That(stat.AverageLetter, Is.EqualTo('B'));
        }
        [Test]
        public void WhenSupervisorGetsGradeAsStringReturnCorrectAverageValue()
        {
            //arrange
            var Supervisor = new Supervisor();
            Supervisor.AddGrade("6");       //100
            Supervisor.AddGrade("6-");      //95
            Supervisor.AddGrade("-6");      //95
            
            Supervisor.AddGrade("5+");      //85
            Supervisor.AddGrade("+5");      //85
            Supervisor.AddGrade("5");       //80
            Supervisor.AddGrade("-5");      //75
            Supervisor.AddGrade("5-");      //75

            Supervisor.AddGrade("4+");      //65
            Supervisor.AddGrade("+4");      //65
            Supervisor.AddGrade("4");       //60
            Supervisor.AddGrade("-4");      //55
            Supervisor.AddGrade("4-");      //55

            Supervisor.AddGrade("3+");      //45
            Supervisor.AddGrade("+3");      //45
            Supervisor.AddGrade("3");       //40
            Supervisor.AddGrade("-3");      //35
            Supervisor.AddGrade("3-");      //35

            Supervisor.AddGrade("2+");      //25
            Supervisor.AddGrade("+2");      //25
            Supervisor.AddGrade("2");       //20
            Supervisor.AddGrade("-2");      //15
            Supervisor.AddGrade("2-");      //15

            Supervisor.AddGrade("1+");      //5
            Supervisor.AddGrade("+1");      //5
            Supervisor.AddGrade("1");       //0
            
            // act
            Statistics stat = Supervisor.GetStatistics();

            // assert
            Assert.That(stat.Average, Is.EqualTo(50));
        }
    }
}
