class Teacher
{
    public string FirstName { get; set; }
    public EventHandler<ExamEventArgs> ExamEvent;
    public void Exam(ExamEventArgs args)
    {
        ExamEvent(this, args);
    }
}

