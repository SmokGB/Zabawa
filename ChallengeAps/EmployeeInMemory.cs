
namespace ChallengeApp
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
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }

            }
            else
            {
                throw new Exception("Invalide grade value");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charResult))
            {
                this.AddGrade(charResult);
            }

            else
            {
                throw new Exception("String is not float");
            }
        }

        public override void AddGrade(double grade)
        {
            float floatValue = (float)grade;
            this.AddGrade(floatValue);
        }

        public override void AddGrade(int grade)
        {
            float floatValue = grade;
            this.AddGrade(floatValue);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'a':
                case 'A':
                    this.AddGrade(100);
                    break;

                case 'b':
                case 'B':
                    this.AddGrade(80);
                    break;
                case 'c':
                case 'C':
                    this.AddGrade(60);
                    break;

                case 'd':
                case 'D':
                    this.AddGrade(40);
                    break;
                case 'e':
                case 'E':
                    this.AddGrade(20);
                    break;

                default:
                    throw new Exception("Range letters [a-A]-[e-E]");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;

            }
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var a when a >= 90:
                    statistics.AverageLetter = 'A';
                    break;
                case var a when a >= 80:
                    statistics.AverageLetter = 'B';
                    break;

                case var a when a >= 70:
                    statistics.AverageLetter = 'C';
                    break;
                case var a when a >= 60:
                    statistics.AverageLetter = 'D';
                    break;

                default:
                    statistics.AverageLetter = 'E';
                    break;

            }

            return statistics;
        }
    }
}


