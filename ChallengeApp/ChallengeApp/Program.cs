using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika 0-100 lub A/a=100 B/b=80 C/c=60 D/d=40 E/e=20   (Q/q - wyjście): ");
    string? input = Console.ReadLine();
    if ((input == "q") ^ (input == "Q"))
    {
        break;
    }
    if ((input == "A") ^ (input == "a") ^ (input == "B") ^ (input == "b") ^ (input == "C") ^ (input == "c") ^ (input == "D") ^ (input == "d") ^ (input == "E") ^ (input == "e"))
    {
        try
        {
            employee.AddGrade(input.ToCharArray(0, 1)[0]);
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
            employee.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }       
    }
}
var statistics = employee.GetStatistics();
Console.WriteLine($"Avg: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");