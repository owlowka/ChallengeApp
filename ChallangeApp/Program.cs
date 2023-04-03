using System.Runtime.CompilerServices;

using ChallangeApp;

[assembly: InternalsVisibleTo("ChallengeApp.Tests")]

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine();

var employee = new Employee();


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
Console.WriteLine($"AVG: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


List<Employee> employees = new List<Employee>()
{
    //employee1,
    //employee2,
   // employee3
};
