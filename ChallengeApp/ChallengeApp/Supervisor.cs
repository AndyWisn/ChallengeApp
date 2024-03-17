
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public string? Name { get; private set; }
        public string? Surname { get; private set; }

        private List<float> grades = new List<float>();


        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
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
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public void AddGrade(ulong grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(uint grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;

            if (this.grades.Count > 0)
            {
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;
                foreach (var grade in this.grades)
                {
                    if (grade < 0)
                    {
                        continue;
                    }
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
                statistics.Average = statistics.Average / this.grades.Count;
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
