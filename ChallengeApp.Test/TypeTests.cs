
namespace ChallengeApp.Test
{
    public class TypeTests
    {
        [Test]
        public void IntegerValueTest()
        {
            //arange
            int a = 1;
            int b = 1;
            //asser
            Assert.AreEqual(a, b);
        }

        [Test]
        public void StringValueTest()
        {
            //arrange
            string name1 = "Jola";
            string name2 = "Jola";
            //assert
            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void EmployeeAgeValueClassTest()
        {
            //arrange
            var user1 = new Employee("Jan", "Kowalski", 25);
            var user2 = new Employee("Anna", "Piekna", 25);
            //assert
            Assert.AreEqual(user1.Age, user2.Age);
        }
        private Employee GetUser(string name, string surnName, int age)
        {
            return new Employee(name, surnName, age);
        }
    }
}
