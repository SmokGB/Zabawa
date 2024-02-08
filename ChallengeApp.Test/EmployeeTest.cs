namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void CheckUserAddScoreMethod()
        {
            //arrange
            var user = new Employee("Jan", "Kowalski", 25);
            user.AddScore(1);
            user.AddScore(6);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(7, result);
        }

        [Test]
        public void CheckUserAddScoreMethodWithMinusPoint()
        {
            //arrange
            var user = new Employee("Jan", "Kowalski", 25);

            user.AddScore(6);
            user.AddScore(-3);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(3, result);
        }


    }
}