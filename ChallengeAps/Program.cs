using ChallengeApp;

var employee = new Employee("Jan", "Kowalski");
employee.AddGrade(150);
employee.AddGrade("Jan");
employee.AddGrade("300");
employee.AddGrade("99");
employee.AddGrade(10);
var statistisc = employee.GetStatistics();
var statistisc1 = employee.GetStatisticsWithForEach();
var statistisc2 = employee.GetStatisticsWithFor();
var statistisc3 = employee.GetStatisticsWithDoWhile();
var statistisc4 = employee.GetStatisticsWithWhile();


Console.WriteLine($"average: {statistisc.Average:n2}");
Console.WriteLine($"min: {statistisc.Min}");
Console.WriteLine($"max: {statistisc.Max}");
Console.WriteLine("=================================");
Console.WriteLine("Dane pętla ForEach");
Console.WriteLine($"average: {statistisc1.Average:n2}");
Console.WriteLine($"min: {statistisc1.Min}");
Console.WriteLine($"max: {statistisc1.Max}");

Console.WriteLine("Dane pętla For");
Console.WriteLine($"average: {statistisc2.Average:n2}");
Console.WriteLine($"min: {statistisc2.Min}");
Console.WriteLine($"max: {statistisc2.Max}");

Console.WriteLine("Dane pętla DoWhile");
Console.WriteLine($"average: {statistisc3.Average:n2}");
Console.WriteLine($"min: {statistisc3.Min}");
Console.WriteLine($"max: {statistisc3.Max}");


Console.WriteLine("Dane pętla While");
Console.WriteLine($"average: {statistisc4.Average:n2}");
Console.WriteLine($"min: {statistisc4.Min}");
Console.WriteLine($"max: {statistisc4.Max}");
