namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string filename = "grades.txt";
        private List<float> grades = new List<float>();

        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {

        }


        public override void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(filename))
                {
                    writer.WriteLine(grade);

                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }

                }

            }
            else
            {
                throw new Exception("invalide grade value");
            }

        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char charresult))
            {
                this.AddGrade(charresult);
            }

            else
            {
                throw new Exception("string is not float");
            }
        }

        public override void AddGrade(double grade)
        {
            float floatvalue = (float)grade;
            this.AddGrade(floatvalue);
        }

        public override void AddGrade(int grade)
        {
            float floatvalue = grade;
            this.AddGrade(floatvalue);
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
                    throw new Exception("range letters [a-a]-[e-e]");
            }
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            Statistics statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;

        }

        private List<float> ReadGradesFromFile()
        {
            if (File.Exists($"{filename}"))
            {
                using (var reader = File.OpenText($"{filename}"))
                {

                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
    }
}