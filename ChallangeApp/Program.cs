using System.Runtime.CompilerServices;

using ChallangeApp;

[assembly: InternalsVisibleTo("ChallengeApp.Tests")]

User u1 = new User("Roksana", "Talisman1");
User u2 = new User("Waldek", "Tajniak4");
User u3 = new User("Mietek", "Atlas7");

u1.AddScore(5);
u1.AddScore(8);
u1.AddScore(1);

u2.AddScore(1);
u2.AddScore(3);
u2.AddScore(6);

u3.AddScore(10);
u3.AddScore(8);
u3.AddScore(9);

int resultU1 = u1.Result;
int resultU2 = u2.Result;
int resultU3 = u3.Result;

List<User> users = new List<User>()
{
    u1,
    u2,
    u3
};


Employee employee1 = new Employee("Roksana", "Talisman", 30);
Employee employee2 = new Employee("Waldek", "Tajniak", 28);
Employee employee3 = new Employee("Mietek", "Atlas", 26);

employee1.AddScore(5);
employee1.AddScore(8);
employee1.AddScore(1);
employee1.AddScore(4);
employee1.AddScore(8);

employee2.AddScore(1);
employee2.AddScore(3);
employee2.AddScore(6);
employee2.AddScore(9);
employee2.AddScore(8);

employee3.AddScore(10);
employee3.AddScore(8);
employee3.AddScore(9);
employee3.AddScore(8);
employee3.AddScore(9);

int resultE1 = employee1.Result;
int resultE2 = employee2.Result;
int resultE3 = employee3.Result;

List<Employee> employees = new List<Employee>()
{
    employee1,
    employee2,
    employee3
};

Employee? bestEmployee = employees.MaxBy(employee => employee.Result);

Console.WriteLine($"Najlepszy pracownik: " +
    $"{bestEmployee.Name} " +
    $"{bestEmployee.Surname} " +
    $"{bestEmployee.Surname} " +
    $"{bestEmployee.Age} " +
    $"Wynik: {bestEmployee.Result}");

