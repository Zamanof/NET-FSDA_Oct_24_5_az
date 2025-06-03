class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public double MarkAvearage { get; set; }

    public void Exam(object sender, ExamEventArgs args)
    {
        if (MarkAvearage > 7) Console.WriteLine($"Teacher: {(sender as Teacher).FirstName} - {FirstName} {LastName} solved {args.Task}");
        else Console.WriteLine($"Teacher: {(sender as Teacher).FirstName} - {FirstName} {LastName} imtahana buraxilmir");
    }
}

