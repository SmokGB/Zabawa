using ChallengeApp;

var employee = new EmployeeInMemory("Jan", "Kowalski");
var employee2 = new EmployeeInFile("Jan", "Kowalski");

employee.GradeAdded += EmployeeGradeAdded;
employee.GradeAdded += EmployeeFileGradeAdded;

void EmployeeFileGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Zapisano ocenę w pliku");
}

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

Console.WriteLine(" --------- Witaj w programie do oceny Pracownika ---------");
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
            employee2.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception : {e.Message}");
        }
    }
} 

/*while (true)
{
    Console.WriteLine("Podaj ocenę kierownika");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }

    else
    {
        try
        {
            supervisor.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception : {e.Message}");
        }
    }
}
*/
var statistisc = employee.GetStatistics();
//var statistiscSupervisor=supervisor.GetStatistics();
Console.WriteLine($"**************** Dane ocen pracownika -> {employee.Name} {employee.Surname} *****************");
Console.WriteLine($"min: {statistisc.Min}");
Console.WriteLine($"max: {statistisc.Max}");
Console.WriteLine($"AVG: {statistisc.Average:n2}");
Console.WriteLine($"Ocena : {statistisc.AverageLetter}");
/*Console.WriteLine($"**************** Dane ocen kierownoika -> {supervisor.Name} {supervisor.Surname} *****************");
Console.WriteLine($"min: {statistiscSupervisor.Min}");
Console.WriteLine($"max: {statistiscSupervisor.Max}");
Console.WriteLine($"AVG: {statistiscSupervisor.Average:n2}");
Console.WriteLine($"Ocena : {statistiscSupervisor.AverageLetter}"); */
