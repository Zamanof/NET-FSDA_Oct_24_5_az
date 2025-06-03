// Events

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

Teacher teacher = new Teacher();

foreach (var student in students)
{
    // event-mize abunelik - event subscribe
    teacher.ExamEvent += student.Exam;
}
teacher.ExamEvent -= students[4].Exam;

teacher.Exam("Sayt yazmaq");
public delegate void ExamDelegate(string task);