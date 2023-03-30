using System.Runtime.CompilerServices;

using ChallangeApp;

[assembly: InternalsVisibleTo("ChallengeApp.Tests")]

Employee employee1 = new Employee("Roksana", "Talisman");
Employee employee2 = new Employee("Waldek", "Tajniak");
Employee employee3 = new Employee("Mietek", "Atlas");

employee1.AddGrade("5");
employee1.AddGrade(2000);
employee1.AddGrade(80d);
employee1.AddGrade(45f);
employee1.AddGrade("Olaf");

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

//Statistics statistics = employee1.GetStatistics();
Statistics statistics1 = employee1.GetStatisticsWithForeach();
Statistics statistics2 = employee1.GetStatisticsWithFor();
Statistics statistics3 = employee1.GetStatisticsWithDoWhile();
Statistics statistics4 = employee1.GetStatisticsWithWhile();


List<Employee> employees = new List<Employee>()
{
    employee1,
    employee2,
    employee3
};

Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Min: {statistics3.Min}");

