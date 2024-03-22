using System.Reflection.PortableExecutable;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate? GradeAdded;
        public const string fileName = "grades.txt";

       // public EmployeeInFile(string name, string surname)
       //    : base(name, surname)
       // {
       // }
       // public EmployeeInFile()
       //     :base()
       // {
       // }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(string? grade)
        {
            if ((!string.IsNullOrWhiteSpace(grade)) && (grade.Length < 3))
            {
                int signDetect = 0;
                int stringscore = 0;
                foreach (char a in grade)
                {
                    switch (a)
                    {
                        case '+':
                            signDetect = 5;
                            break;
                        case '-':
                            signDetect = -5;
                            break;
                        case '6':
                            stringscore = 100;
                            break;
                        case '5':
                            stringscore = 80;
                            break;
                        case '4':
                            stringscore = 60;
                            break;
                        case '3':
                            stringscore = 40;
                            break;
                        case '2':
                            stringscore = 20;
                            break;
                        case '1':
                        case '0':
                            stringscore = 0;
                            break;
                        default:
                            throw new Exception("Unsupported grade");
                    }
                }
                stringscore += signDetect;

                    if (stringscore < 0)
                    {
                        this.AddGrade(0);
                    }
                    else if (stringscore > 100)
                    {
                        this.AddGrade(100);
                    }
                    else
                    {
                        this.AddGrade(stringscore);
                    }                
            }
            else
            {
                throw new Exception("Wrong grade string");
            }
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var gradesCounter = 0;

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {

                    string? line = null;

                    while ((line = reader.ReadLine()) != null)
                    {

                        var grade = float.Parse(line);
                        if (grade >= 0)
                        {
                            statistics.Max = Math.Max(statistics.Max, grade);
                            statistics.Min = Math.Min(statistics.Min, grade);
                            statistics.Average += grade;
                            gradesCounter++;
                        }
                    }
                    if (gradesCounter > 0)
                    {
                        statistics.Average = statistics.Average / gradesCounter;
                    }
                    else
                    {
                        statistics.Min = 0;
                        statistics.Max = 0;
                    }
                }
            }
            else
            {
                statistics.Min = 0;
                statistics.Max = 0;
            }

            switch (statistics.Average)
            {
                case var a when a >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var a when a >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var a when a >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var a when a >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}