using System;
using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        public void AddGrade(char grade)
        {
            this.AddGrade(grade.ToString());
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
            return statistics;
        }
        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Average = 0;

            if (this.grades.Count > 0)
            {
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;

                foreach (var grade in this.grades)
                {
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
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;

            if (this.grades.Count > 0)
            {
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;
                var index = 0;
                do
                {
                    statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                    statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                    statistics.Average += grades[index];
                    index++;
                }
                while (index < this.grades.Count);
                statistics.Average = statistics.Average / this.grades.Count;
            }
            else
            {
                statistics.Min = 0;
                statistics.Max = 0;
            }
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;

            if (this.grades.Count > 0)
            {
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;

                var index = 0;

                while (index < this.grades.Count)
                {
                    statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                    statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                    statistics.Average += grades[index];
                    index++;
                }
                statistics.Average = statistics.Average / this.grades.Count;
            }
            else
            {
                statistics.Min = 0;
                statistics.Max = 0;
            }
            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;

            if (this.grades.Count > 0)
            {
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;
                for (var index = 0; index < this.grades.Count; index++)
                {
                    statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                    statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                    statistics.Average += grades[index];
                }
                statistics.Average = statistics.Average / this.grades.Count;
            }
            else
            {
                statistics.Min = 0;
                statistics.Max = 0;
            }
            return statistics;
        }
    }
}
