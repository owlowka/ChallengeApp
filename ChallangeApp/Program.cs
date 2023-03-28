using System.Runtime.CompilerServices;

using ChallangeApp;

[assembly: InternalsVisibleTo("ChallengeApp.Tests")]

Employee employee1 = new Employee("Roksana", "Talisman");
Employee employee2 = new Employee("Waldek", "Tajniak");
Employee employee3 = new Employee("Mietek", "Atlas");

employee1.AddGrade(55);
employee1.AddGrade(80);
employee1.AddGrade(11);
employee1.AddGrade(45);
employee1.AddGrade(91);

employee2.AddGrade(11);
employee2.AddGrade(31);
employee2.AddGrade(61);
employee2.AddGrade(91);
employee2.AddGrade(81);

employee3.AddGrade(10);
employee3.AddGrade(82);
employee3.AddGrade(93);
employee3.AddGrade(84);
employee3.AddGrade(95);

Statistics statistics = employee1.GetStatistics();

List<Employee> employees = new List<Employee>()
{
    employee1,
    employee2,
    employee3
};

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");

