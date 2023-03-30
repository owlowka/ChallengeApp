using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ChallangeApp
{
    internal class Employee
    {
        private List<float> grades = new List<float>();

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
                //throw new Exception($"Pracownik: {Name} {Surname} Nieprawidłowa ocena. Zakres ocen od 0-100");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result)) 
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddGrade(int grade)
        {
            float valueInIntToFloat = (float)grade;

            this.AddGrade(valueInIntToFloat);

        }
        public void AddGrade(double grade)
        {
            float valueInDoubleToFloat = (float)grade;

            this.AddGrade(valueInDoubleToFloat);

        }
        public void AddGrade(decimal grade)
        {
            float valueInDecimalToFloat = (float)grade;

            this.AddGrade(valueInDecimalToFloat);

        }

        public void AddGrade(long grade)
        {
            float valueInLongToFloat = (float)grade;

            AddGrade(valueInLongToFloat);

        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }

    }
}
