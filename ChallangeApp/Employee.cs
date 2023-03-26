using System.Runtime.CompilerServices;

namespace ChallangeApp
{
    internal class Employee
    {
        private List <int> score = new List <int> ();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public Employee() 
        {
            
        }
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public void AddScore(int number)
        {
            if (number >= 1 && number <= 10)
            {
                this.score.Add(number);
            }
            else
            {
                //Console.WriteLine($"Pracownik: {Name} {Surname} Nieprawidłowa ocena. Zakres ocen od 1-10");

                throw new Exception($"Pracownik: {Name} {Surname} Nieprawidłowa ocena. Zakres ocen od 1-10");
            }
        }

    }
}
