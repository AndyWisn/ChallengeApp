using ChallengeApp;

var employee = new Employee("Andrzej", "Wiśniewski");
employee.AddGrade("12");                    //string jako liczba
employee.AddGrade("Adam");                  //string jako nie liczba
employee.AddGrade('A');                     //char jako nie liczba    
employee.AddGrade('1');                     //char jako liczba
employee.AddGrade(Math.PI);                 //double
employee.AddGrade(2345345345345345);        //long
employee.AddGrade(5534);                    //int

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");