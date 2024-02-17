using ChallengeApp;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrade(150);
employee.AddGrade("Jan");
employee.AddGrade("300");
employee.AddGrade("99");
employee.AddGrade(10);
var statistisc = employee.GetStatistics();
Console.WriteLine($"average: {statistisc.Average:n2}");
Console.WriteLine($"min: {statistisc.Min}");
Console.WriteLine($"max: {statistisc.Max}");