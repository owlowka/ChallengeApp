using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallangeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor()
        {

        }
        public Supervisor(string name, string surname)

        {
            this.Name = name;
            this.Surname = surname;
        }

        public Supervisor(string name, string surname, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            Sex = sex;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }

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
            int value = grade switch
            {
                "6" => 100,
                "5" => 80,
                "4" => 60,
                "-3" or "3-" => 35,
                "+2" or "3+" => 25,
                "2" => 20,
                "1" => 0,
                _ => throw new ArgumentOutOfRangeException("Nieprawidłowa ocena. Wprowadź wartość 1-6")
            };

            grades.Add(value);
        }

        public void AddGrade(char grade)
        {
            int value = grade switch
            {
                'A' or 'a' => 100,
                'B' or 'b' => 80,
                'C' or 'c' => 60,
                'D' or 'd' => 40,
                'E' or 'e' => 20,
                _ => throw new ArgumentOutOfRangeException("Nieprawidłowa ocena. Wprowadź wartość od A-E")
            };
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
