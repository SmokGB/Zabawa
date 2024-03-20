using ChallengeApp;

var employee2 = new EmployeeInFile("Jan", "Kowalski");

employee2.GradeAdded += EmployeeGradeAdded;
employee2.GradeAdded += EmployeeFileGradeAdded;

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
            employee2.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception : {e.Message}");
        }
    }
}

var statistisc = employee2.GetStatistics();
Console.WriteLine($"**************** Dane ocen pracownika -> {employee2.Name} {employee2.Surname} *****************");
Console.WriteLine($"min: {statistisc.Min}");
Console.WriteLine($"max: {statistisc.Max}");
Console.WriteLine($"Suma ocen : {statistisc.Sum}");
Console.WriteLine($"Ilosc ocen : {statistisc.Count}");
Console.WriteLine($"AVG: {statistisc.Average:n2}");
Console.WriteLine($"Ocena : {statistisc.AverageLetter}");