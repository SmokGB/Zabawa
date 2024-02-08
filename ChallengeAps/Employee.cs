using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{

    public class Employee
    {
        private List<int> userPoints = new List<int>();
        public Employee(string name, string lastName, int age)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
        }
        public string Name
        {
            private set; get;
        }
        public string LastName
        {
            private set; get;
        }
        public int Age
        {
            private set; get;
        }

        public void AddScore(int number)
        {
            this.userPoints.Add(number);
        }

        public int Result
        {
            get
            {
                return this.userPoints.Sum();
            }
        }
    }
}