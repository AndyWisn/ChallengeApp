using ChallengeApp;

List<Employee> Employees = new List<Employee>();

Employees.Add(new Employee("Ada", "Kowalska", 46));
Employees.Add(new Employee("Anna", "Kowalska", 36));
Employees.Add(new Employee("Jan", "Kowalski", 26));

Console.WriteLine("Employees:");
Console.WriteLine("");

Random randomScore = new Random();
var maxScore = 0;
foreach (Employee emp in Employees)
{
    for (var i = 0; i < 5; i++) emp.AddScore(randomScore.Next(1, 10));
    Console.WriteLine(emp.name + " " + emp.surname + " Age:" + emp.age + " Score: " + emp.Result);
    if (emp.Result > maxScore) maxScore = emp.Result;
}

//Employee employeeMax = new Employee("", "", 0);
//employeeMax.AddScore(0);
Console.WriteLine("List of employees with best score: ");
foreach (Employee emp in Employees)
{
    if (emp.Result == maxScore)
    {
        Console.WriteLine("Hi score: " + emp.Result + " Employee: " + emp.name + " " + emp.surname + " Age:" + emp.age);
    }
}




