// Singleton Pattern
// https://refactoring.guru/design-patterns/singleton

President president;

president = President.GetInstance("Donald", "Trump", 79);
Console.WriteLine(president);
President president1 = President.GetInstance("Jorgie","Bush", 86);
Console.WriteLine(president1);
class President
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    private static President _instance = null;

    private President(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    static public President GetInstance(string name, string lastname, int age)
    {
        if (_instance is null)
        {
            _instance = new(name, lastname, age);
        }
        return _instance;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} - {Age}";
    }
}
