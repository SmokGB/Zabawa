﻿//namespace ChallengeApp
//{

//    public class Supervisor : EmployeeBase
//    {

//        private List<float> grades = new List<float>();

     
//        public  override event GradeAddedDelegate GradeAdded;
//        public Supervisor(string name, string surname) : base(name, surname)
//        {
//        }

//        public string Name => "Jan";
//        public string Surname => "Kierownik";

        

//        public override void AddGrade(float grade)
//        {
//            if (grade >= 0 && grade <= 100)
//            {
//                this.grades.Add(grade);
//            }
//            else
//            {
//                throw new Exception("Invalide grade value");
//            }
//        }

//        public override void AddGrade(string grade)
//        {
//            switch (grade)
//            {
//                case "6":
//                    this.AddGrade(100);
//                    break;
//                case "6-" or "-6":
//                    this.AddGrade(95);
//                    break;

//                case "5":
//                    this.AddGrade(80);
//                    break;
//                case "5-" or "-5":
//                    this.AddGrade(75);
//                    break;
//                case "5+" or "+5":
//                    this.AddGrade(85);
//                    break;

//                case "4":
//                    this.AddGrade(60);
//                    break;
//                case "4-" or "-4":
//                    this.AddGrade(55);
//                    break;
//                case "4+" or "+4":
//                    this.AddGrade(65);
//                    break;

//                case "3":
//                    this.AddGrade(40);
//                    break;
//                case "3-" or "-3":
//                    this.AddGrade(35);
//                    break;
//                case "3+" or "+3":
//                    this.AddGrade(45);
//                    break;

//                case "2":
//                    this.AddGrade(20);
//                    break;
//                case "2-" or "-2":
//                    this.AddGrade(15);
//                    break;
//                case "2+" or "+2":
//                    this.AddGrade(25);
//                    break;
//                case "1":
//                    this.AddGrade(0);
//                    break;
//                default:
//                    if (float.TryParse(grade, out float result))
//                    {
//                        this.AddGrade(result);
//                    }
//                    else if (char.TryParse(grade, out char charResult))
//                    {
//                        this.AddGrade(charResult);
//                    }

//                    else
//                    {
//                        throw new Exception("String is not float");
//                    }
//                    break;
//            }
//        }


//        public override void AddGrade(double grade)
//        {
//            float floatValue = (float)grade;
//            this.AddGrade(floatValue);

//        }

//        public override void AddGrade(int grade)
//        {
//            float floatValue = grade;
//            this.AddGrade(floatValue);
//        }

//        public override void AddGrade(char grade)
//        {
//            switch (grade)
//            {
//                case 'a':
//                case 'A':
//                    this.AddGrade(100);
//                    break;

//                case 'b':
//                case 'B':
//                    this.AddGrade(80);
//                    break;
//                case 'c':
//                case 'C':
//                    this.AddGrade(60);
//                    break;

//                case 'd':
//                case 'D':
//                    this.AddGrade(40);
//                    break;
//                case 'e':
//                case 'E':
//                    this.AddGrade(20);
//                    break;

//                default:
//                    throw new Exception("Range letters [a-A]-[e-E]");
//            }
//        }
//        public override Statistics GetStatistics()
//        {
//            var statistics = new Statistics();
//            statistics.Average = 0;
//            statistics.Max = float.MinValue;
//            statistics.Min = float.MaxValue;

//            foreach (var grade in this.grades)
//            {
//                statistics.Max = Math.Max(statistics.Max, grade);
//                statistics.Min = Math.Min(statistics.Min, grade);
//                statistics.Average += grade;

//            }
//            statistics.Average /= this.grades.Count;

//            switch (statistics.Average)
//            {
//                case var a when a >= 90:
//                    statistics.AverageLetter = 'A';
//                    break;
//                case var a when a >= 80:
//                    statistics.AverageLetter = 'B';
//                    break;

//                case var a when a >= 70:
//                    statistics.AverageLetter = 'C';
//                    break;
//                case var a when a >= 60:
//                    statistics.AverageLetter = 'D';
//                    break;

//                default:
//                    statistics.AverageLetter = 'E';
//                    break;

//            }

//            return statistics;
//        }

//    }
//}