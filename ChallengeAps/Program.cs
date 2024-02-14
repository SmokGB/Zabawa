using ChallengeApp;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrade(3);
employee.AddGrade(7);
employee.AddGrade(10);
var statistisc = employee.GetStatistics();
Console.WriteLine($"Average: {statistisc.Average:N2}");
Console.WriteLine($"Min: {statistisc.Min}");
Console.WriteLine($"Max: {statistisc.Max}");
  
