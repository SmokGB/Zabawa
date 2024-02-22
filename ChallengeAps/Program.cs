using ChallengeApp;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrade("30");
employee.AddGrade("99f");
employee.AddGrade(60);
employee.AddGrade('d');
var statistisc = employee.GetStatistics();
Console.WriteLine(statistisc.AverageLetter);
