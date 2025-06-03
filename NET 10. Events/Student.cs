// Events
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public double MarkAvearage { get; set; } 

    public void Exam(string task) {
        if (MarkAvearage > 7) Console.WriteLine($"{FirstName} {LastName} solved {task}");
        else Console.WriteLine($"{FirstName} {LastName} imtahana buraxilmir");
    }
}
