
using ChallangeApp;
using System.Xml.Linq;

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void WhenAddGradeInvokedWithFiveInts_ThenShouldReturnMaxValue()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");

            employee1.AddGrade(55);
            employee1.AddGrade(80);
            employee1.AddGrade(11);
            employee1.AddGrade(45);
            employee1.AddGrade(91);

            //act
            Statistics statistics = new Statistics();
            statistics = employee1.GetStatistics();

            //assert
            Assert.AreEqual(91, statistics.Max);
        }

        [Test]
        public void WhenAddGradeInvokedWithFiveInts_ThenShouldReturnMinValue()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");

            employee1.AddGrade(55);
            employee1.AddGrade(80);
            employee1.AddGrade(11);
            employee1.AddGrade(45);
            employee1.AddGrade(91);

            //act
            Statistics statistics = new Statistics();
            statistics = employee1.GetStatistics();

            //assert
            Assert.AreEqual(11, statistics.Min);
        }

        [Test]
        public void WhenAddGradeInvokedWithFiveInts_ThenShouldReturnAverageValue()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");

            employee1.AddGrade(55);
            employee1.AddGrade(80);
            employee1.AddGrade(11);
            employee1.AddGrade(45);
            employee1.AddGrade(91);

            //act
            Statistics statistics = new Statistics();
            statistics = employee1.GetStatistics();

            //assert
            Assert.AreEqual((Math.Round(56.4)), (Math.Round(statistics.Average)));
        }

        [Test]
        public void WhenAddGradeInvokedWithTwoFloats_ThenShouldReturnAverageValue()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");

            employee1.AddGrade(85.0f);
            employee1.AddGrade(98.0f);

            //act
            Statistics statistics = new Statistics();
            statistics = employee1.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(92.0), Math.Round(statistics.Average));
        }

        [Test]
        public void WhenAddGradeInvokedOneIntOutOfRangeHigh_ThenShouldReturnArgumentOutOfRangeException()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");

            //act//assert
            Assert.Throws<ArgumentOutOfRangeException>(() => employee1.AddGrade(101));
        }

        [Test]
        public void WhenAddGradeInvokedWithTwoOneOutOfRangeLow_ThenShouldReturnArgumentOutOfRangeException()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");

            //act
            Assert.Throws<ArgumentOutOfRangeException>(() => employee1.AddGrade(-1));
        }

        [Test]
        public void WhenAddGradeInvokedWithTwoBigLetters_ThenShouldReturnAverageValue()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");

            employee1.AddGrade("A");
            employee1.AddGrade("B");

            //act
            Statistics statistics = new Statistics();
            statistics = employee1.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(90.0), Math.Round(statistics.Average));
        }

        [Test]
        public void WhenAddGradeInvokedWithTwoSmallLetters_ThenShouldReturnAverageValue()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");

            employee1.AddGrade("c");
            employee1.AddGrade("d");

            //act
            Statistics statistics = new Statistics();
            statistics = employee1.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(50.0), Math.Round(statistics.Average));

        }

        [Test]
        public void WhenAddGradeInvokedWithLetterOutOfRange_ThenShouldReturnInfoMessage()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");

            //act//assert
            Assert.Throws<ArgumentOutOfRangeException>(() => employee1.AddGrade('o'));
        }

        [Test]
        public void WhenAddGradeInvokedWithMoreThanOneCharacterAtOnceFirstCharacterOutOfRange_ThenShouldArgumentOutOfRangeException()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");

            //act//assert
            Assert.Throws<ArgumentOutOfRangeException>(() => employee1.AddGrade("Ola"));
        }

        [Test]
        public void WhenAddGradeInvokedWithMoreThanOneCharacterAtOnceFirstCharacterInRange_ThenShouldReturnAverageValue()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");
            employee1.AddGrade("Ala");

            //act
            Statistics statistics = new Statistics();
            statistics = employee1.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(100.0), Math.Round(statistics.Average));
        }

        [Test]
        public void WhenAddGradeInvokedTwiceWithMoreThanOneCharacterFirstInRange_ThenShouldReturnAverageValue()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");
            employee1.AddGrade("Ala");
            employee1.AddGrade("Ela");


            //act
            Statistics statistics = new Statistics();
            statistics = employee1.GetStatistics();

            //assert
            Assert.AreEqual(Math.Round(60.0), Math.Round(statistics.Average));
        }

        [Test]
        public void WhenAddGradeInvokedTwiceWithMoreThanOneCharacterAtOutOfAndInRange_ThenShouldReturnArgumentOutOfRangeException()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");

            //act//assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                employee1.AddGrade("Ala");
                employee1.AddGrade("Ola");
            });
        }

        [Test]
        public void WhenAddGradeInvokedTwiceWithMoreThanOneCharacterAtOutOfAndInRange_ThenShouldReturnLetterAverageValue()
        {
            //arrange
            Employee employee1 = new Employee("Roksana", "Talisman");
            employee1.AddGrade("Ala");
            employee1.AddGrade("Ela");

            char letter = 'C';

            //act
            Statistics statistics = new Statistics();
            statistics = employee1.GetStatistics();

            //assert
            Assert.That(statistics.AverageLetter, Is.EqualTo(letter));
        }

    }
}