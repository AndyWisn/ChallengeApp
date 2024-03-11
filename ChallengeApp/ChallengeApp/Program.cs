using ChallengeApp;

var employee = new Employee("Andrzej", "Wiśniewski");
employee.AddGrade("12");                    //string as a number
employee.AddGrade("Adam");                  //string as not a number
employee.AddGrade('A');                     //char but not a digit
employee.AddGrade('1');                     //char as a digit
employee.AddGrade(Math.PI);                 //double
employee.AddGrade(2345345345345345);        //long
employee.AddGrade(5534);                    //int

var statistics = employee.GetStatistics();
Console.WriteLine("");

Console.WriteLine("GetStatistics Original:");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine("");

statistics = employee.GetStatisticsWithFor();
Console.WriteLine("GetStatistics With For:");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine("");

statistics = employee.GetStatisticsWithForEach();
Console.WriteLine("Original GetStatistics With For Each:");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine("");

statistics = employee.GetStatisticsWithDoWhile();
Console.WriteLine("Original GetStatistics With Do While:");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine("");

statistics = employee.GetStatisticsWithWhile();
Console.WriteLine("Original GetStatistics with While:");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine("");