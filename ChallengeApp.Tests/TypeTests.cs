using ChallangeApp;


namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        //Testing reference type

        [Test]
        public void WhenUsersHaveSameNames_ShouldReturnSameLoginObjects()
        {
            //arrange
            var user1 = GetUser("Roksana");
            var user2 = GetUser("Roksana");

            //act//assert
            Assert.AreEqual(user1.Login, user2.Login);
        }

        [Test]
        public void WhenUsersHaveSameNamesAndDifferentPasswords_ShouldNotReturnSameLoginObjects()
        {
            //arrange
            var user1 = GetUser("Roksana", "1234");
            var user2 = GetUser("Roksana", "4562");

            //act//assert
            Assert.AreNotSame(user1.Password, user2.Password);
        }

        //Testing value type
        [Test]
        public void WhenIntVariablesHaveSameValues_ShouldReturnEqualValues()
        {
            //arrange
            int n1 = 10;
            int n2 = 10;

            //act//assert
            Assert.AreEqual(n1,n2);
        }

        [Test]
        public void WhenFloatVariablesHaveDiferrentValues_ShouldReturnFirstValueIsSmallerThanSecondValue()
        {
            //arrange
            float f1 = 11.7f;
            float f2 = 14.3f;

            //act//assert
            Assert.Less(f1, f2);
        }

        [Test]
        public void WhenStringVariablesHaveDiferrentValues_ShouldReturnNotEqualValues()
        {
            //arrange
            string s1 = "Wilcze";
            string s2 = "Jagody";
            //act//assert
            Assert.IsFalse(s1.Equals(s2));
        }

        [Test]
        public void WhenStringVariablesHaveSameValues_ShouldReturnEqualValues()
        {
            //arrange
            string s1 = "Wilcze";
            string s2 = "Wilcze";
            //act//assert
            Assert.IsTrue(s1.Equals(s2));
        }

        private User GetUser(string name, string login)
        {
            return new User(name, login);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
