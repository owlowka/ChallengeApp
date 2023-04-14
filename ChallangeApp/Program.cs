using System.Runtime.CompilerServices;

using ChallangeApp;

[assembly: InternalsVisibleTo("ChallengeApp.Tests")]

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine();

var employee = new EmployeeInFile("Roksana", "Talisaman");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

while (true)
{
    Console.WriteLine("Podaj Ocenę pracownika: ");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch(ArgumentOutOfRangeException exc)
    {
        Console.WriteLine(exc.Message);
    }
}

Statistics statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


/*
List<Employee> employees = new List<Employee>()
{
    //employee1,
    //employee2,
   // employee3
};
*/

