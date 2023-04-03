using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ChallangeApp
{
    internal class Employee
    {
        private readonly char sex = 'M';

        private List<float> grades = new List<float>();

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Employee()
        {

        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.sex = 'K';
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0.0 && grade <= 100.0)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Nieprawidłowa ocena. Wprowadź wartość od 0 do 100");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (grade.Length > 0)
            {
                AddGrade(grade.First());
            }
            else
            {
                throw new ArgumentOutOfRangeException("Nieprawidłowa ocena");
            }
        
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Nieprawidłowa ocena. Wprowadź wartość od A-E");
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
            Statistics statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }

            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 80:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
