

using ChallangeApp;

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

int result1 = employee1.Result;
int result2 = employee2.Result;
int result3 = employee3.Result;

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

