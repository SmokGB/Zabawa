using ChallengeApp;

List<Employee> users = new List<Employee>();

Employee user1 = new Employee("Jan", "Kowalski", 32);
users.Add(user1);
Employee user2 = new Employee("Anna", "Nowak", 45);
users.Add(user2);
Employee user3 = new Employee("Krzysztof", "Pospolity", 60);
users.Add(user3);

user1.AddScore(5);
user1.AddScore(7);
user1.AddScore(8);

user2.AddScore(1);
user2.AddScore(10);
user2.AddScore(3);

user3.AddScore(10);
user3.AddScore(8);
user3.AddScore(8);

int maxUserPoints = 0;
Employee? userWithMaxResult = null;

foreach (var user in users)
{
    if (user.Result > maxUserPoints)
    {
        userWithMaxResult = user;
        maxUserPoints = user.Result;

    }
}

Console.WriteLine($"Pracownik z majwyzsza iloscia punktow : {userWithMaxResult.Result}");
Console.WriteLine($"Imie : {userWithMaxResult.Name}");
Console.WriteLine($"Nazwisko : {userWithMaxResult.LastName}");
Console.WriteLine($"Wiek : {userWithMaxResult.Age}");
