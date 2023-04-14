
namespace ChallangeApp
{
    public class EmployeeInMemory : EmployeeBase
    {

        private List<float> grades = new List<float>();

        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0.0 && grade <= 100.0)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }

            }
            else
            {
                throw new ArgumentOutOfRangeException("Nieprawidłowa ocena. Wprowadź wartość od 0 do 100");
            }
        }

        public override void AddGrade(double grade)
        {
            float valueInDoubleToFloat = (float)grade;

            this.AddGrade(valueInDoubleToFloat);
        }

        public override void AddGrade(int grade)
        {
            float valueInIntToFloat = (float)grade;

            this.AddGrade(valueInIntToFloat);
        }

        public override void AddGrade(char grade)
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

        public override void AddGrade(string grade)
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

        public override Statistics GetStatistics()
        {
            Statistics statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}
