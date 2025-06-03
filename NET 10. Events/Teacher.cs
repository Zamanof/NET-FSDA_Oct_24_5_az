// Events
class Teacher
{
    public event ExamDelegate? ExamEvent;
    public void Exam(string task)
    {
        ExamEvent(task);
    }
}
