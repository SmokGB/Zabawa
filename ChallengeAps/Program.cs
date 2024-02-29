// stary PC
using ChallengeApp;

var employee = new Employee();
Console.WriteLine(" --------- WItaj w programie do oceny Pracownika ---------");
Console.WriteLine("****************************************************************");

while (true)
{
    Console.WriteLine("Podaj ocenę pracowika");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }

    else
    {
        try
        {
            employee.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception : {e.Message}");
        }
    }
}
var statistisc = employee.GetStatistics();
Console.WriteLine($"**************** Dane ocen pracownika -> {employee.Name} {employee.Surname} *****************");
Console.WriteLine($"min: {statistisc.Min}");
Console.WriteLine($"max: {statistisc.Max}");
Console.WriteLine($"AVG: {statistisc.Average:n2}");
Console.WriteLine($"Ocena : {statistisc.AverageLetter}");
