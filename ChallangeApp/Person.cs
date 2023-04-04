using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallangeApp
{
    abstract class Person
    {
        protected int counter;

        public Person()
        {

        }
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Person(string name, string surname, string? sex)
            : this(name, surname)
        {
            this.Sex = sex;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string? Sex { get; private set; }

    }
}
