namespace ChallengeApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void CheckMinValGetStatisticMethod()
        {
            //arrange
            var user = new Employee("Jan", "Kowalski");
            user.AddGrade(10);
            user.AddGrade(9);
            user.AddGrade(2);

            //act
            Statistics usersummary = user.GetStatistics();

            //assert
            Assert.AreEqual(2, usersummary.Min);

        }

        [Test]
        public void CheckMaxValueGetStatisticMethod()
        {
            //arrange
            var user = new Employee("Jan", "Kowalski");
            user.AddGrade(10);
            user.AddGrade(9);
            user.AddGrade(2);

            //act
            Statistics usersummary = user.GetStatistics();

            //assert
            Assert.AreEqual(10, usersummary.Max);
        }

        [Test]
        public void CheckAvgValueGetStaticsMethod()
        {
            //arrange
            var user = new Employee("Jan", "Kowalski");
            user.AddGrade(10);
            user.AddGrade(9);
            user.AddGrade(2);

            //act
            Statistics usersummary = user.GetStatistics();

            //assert
            Assert.AreEqual((float)7, usersummary.Average);
        }

    }
}