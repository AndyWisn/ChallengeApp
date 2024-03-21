using ChallengeApp;
using System.Reflection;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee1 = new EmployeeInMemory();
var employee2 = new EmployeeInFile();

if (File.Exists(EmployeeInFile.fileName))
{
    File.Delete(EmployeeInFile.fileName);
}

while (true)
{
    Console.WriteLine("Enter the employee's next grade. Range: 1-6(-/+) or A/a=100 B/b=80 C/c=60 D/d=40 E/e=20   (Q/q - quit): ");
    string? input = Console.ReadLine();
    if ((input == "q") ^ (input == "Q"))
    {
        break;
    }
    if ((input == "A") ^ (input == "a") ^ (input == "B") ^ (input == "b") ^ (input == "C") ^ (input == "c") ^ (input == "D") ^ (input == "d") ^ (input == "E") ^ (input == "e"))
    {
        try
        {
            employee1.AddGrade(input.ToCharArray(0, 1)[0]);
            employee2.AddGrade(input.ToCharArray(0, 1)[0]);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
    else
    {
        try
        {
            employee1.AddGrade(input);
            employee2.AddGrade(input);
        }       
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }   
    }
}
var statistics = employee1.GetStatistics();
Console.WriteLine("Statistics from memory:");
Console.WriteLine($"Avg: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

statistics = employee2.GetStatistics();
Console.WriteLine("Statistics from file:");
Console.WriteLine($"Avg: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");