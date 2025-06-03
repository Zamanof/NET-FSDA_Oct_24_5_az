List<Student> students = new()
{
    new Student{FirstName = "John", LastName = "Doe", Age=25, MarkAvearage = 8},
    new Student{FirstName = "Jane", LastName = "Smith", Age=22, MarkAvearage = 6.5},
    new Student{FirstName = "Alice", LastName = "Johnson", Age=23, MarkAvearage = 10},
    new Student{FirstName = "Bob", LastName = "Brown", Age=13, MarkAvearage = 8},
    new Student{FirstName = "Charlie", LastName = "Davis", Age=21, MarkAvearage = 8},
    new Student{FirstName = "Eve", LastName = "Wilson", Age=15, MarkAvearage = 3.5},
    new Student{FirstName = "Frank", LastName = "Garcia", Age=20, MarkAvearage = 12},
    new Student{FirstName = "Grace", LastName = "Martinez", Age=27, MarkAvearage = 8},
    new Student{FirstName = "Hank", LastName = "Lopez", Age=14, MarkAvearage = 8.5},
    new Student{FirstName = "Ivy", LastName = "Gonzalez", Age=29, MarkAvearage = 6.8}
    };

Teacher teacher1 = new Teacher();
Teacher teacher2 = new Teacher();
teacher1.FirstName = "Nadir";
teacher2.FirstName = "Lale";
for (int i = 0; i < students.Count; i++)
{
    if (i % 2 == 0) teacher1.ExamEvent += students[i].Exam;
    else teacher2.ExamEvent += students[i].Exam;
}

ExamEventArgs ExamEventArgs = new ExamEventArgs { Task = "Sayt yazmaq" };
teacher1.Exam(ExamEventArgs);
teacher2.Exam(new ExamEventArgs { Task = "C# kodu yazmaq" });

public delegate void ExamDelegate(string task);

