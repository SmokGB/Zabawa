namespace ChallengeApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void CheckLetterValueGetStatisticMethod()
        {
            //arrange
            var user = new EmployeeInMemory("Jan", "Kowalski");
            user.AddGrade('A');
            user.AddGrade('C');
            user.AddGrade('z');

            //act
            Statistics usersummary = user.GetStatistics();

            //assert
            Assert.AreEqual('B', usersummary.AverageLetter);

        }

        [Test]
        public void CheckValueReturnsGetStatisticMethod()
        {
            //arrange
            var user = new EmployeeInMemory("Jan", "Kowalski");
            user.AddGrade(50f);
            user.AddGrade("60");
            user.AddGrade('C');

            //act
            Statistics usersummary = user.GetStatistics();

            //assert
            Assert.AreEqual(60, usersummary.Max);
            Assert.AreEqual(50, usersummary.Min);
            Assert.AreEqual(56.67, Math.Round(usersummary.Average, 2));
            Assert.AreEqual('E', usersummary.AverageLetter);

        }
    }
}