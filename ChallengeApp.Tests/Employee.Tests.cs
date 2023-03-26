
using ChallangeApp;
using System.Xml.Linq;

namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenEmployeeCollectTwoSetOfPoints_ThenShouldReturnCorrectSumAsResult()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman", 30);

            employee1.AddScore(5);
            employee1.AddScore(8);

            //act
            int result = employee1.Result;

            //assert
            Assert.AreEqual(13, result);
        }

        [Test]
        public void WhenEmployeeCollectTwoSetOfPoints_ThenConsoleShouldWriteNameSurnameAndResult()
        {
            //arrange
            Employee employee2 = new Employee("Waldek", "Tajniak", 28);
            employee2.AddScore(10);
            employee2.AddScore(8);

            //act
            int result = employee2.Result;
            Console.WriteLine($"{employee2.Name} {employee2.Surname} wynik: {result}");

            //assert

            Assert.Pass("Waldek Tajniak wynik: 18");
        }

        [Test]
        public void WhenEmployeeCollectTwoSetOfPointsWithZeroValue_ThenConsoleShouldWriteSpecialSentence()
        {
            //arrange
            Employee employee2 = new Employee("Waldek", "Tajniak", 28);

            //act//assert
            Assert.Throws<Exception>(() => employee2.AddScore(0));
        }

        [Test]
        public void WhenEmployeeCollectTwoSetOfPointsWithNegativeValue_ThenConsoleShouldWriteSpecialSentence()
        {
            //arrange
            Employee employee2 = new Employee("Waldek", "Tajniak", 28);

            //act//assert
            Assert.Throws<Exception>(() => employee2.AddScore(-1));
        }
    }
}