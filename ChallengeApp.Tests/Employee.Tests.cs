
using ChallangeApp;
using System.Xml.Linq;

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenEmployeeCollectFiveSetOfPoints_ThenShouldReturnMaxValue()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");

            employee1.AddGrade(55);
            employee1.AddGrade(80);
            employee1.AddGrade(11);
            employee1.AddGrade(45);
            employee1.AddGrade(91);

            Statistics statistics = new Statistics();
            statistics = employee1.GetStatistics();


            //act//assert
            Assert.AreEqual(91, statistics.Max);

        }

        [Test]
        public void WhenEmployeeCollectFiveSetOfPoints_ThenShouldReturnMinValue()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");

            employee1.AddGrade(55);
            employee1.AddGrade(80);
            employee1.AddGrade(11);
            employee1.AddGrade(45);
            employee1.AddGrade(91);

            Statistics statistics = new Statistics();
            statistics = employee1.GetStatistics();


            //act//assert
            Assert.AreEqual(11, statistics.Min);

        }
        [Test]
        public void WhenEmployeeCollectFiveSetOfPoints_ThenShouldReturnAverageValue()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");

            employee1.AddGrade(55);
            employee1.AddGrade(80);
            employee1.AddGrade(11);
            employee1.AddGrade(45);
            employee1.AddGrade(91);

            Statistics statistics = new Statistics();
            statistics = employee1.GetStatistics();

            //act//assert
            Assert.AreEqual(56,4 , statistics.Average);

        }

    }
}