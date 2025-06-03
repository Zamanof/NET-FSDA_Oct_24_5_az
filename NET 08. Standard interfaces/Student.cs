// Standard interfaces
class Student : IComparable, ICloneable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public StudentCard StudentCard { get; set; }

    public object Clone()
    {
        // deep copy
        Student tmp = this.MemberwiseClone() as Student;
        tmp.StudentCard = new StudentCard { Id = this.StudentCard.Id, Series = this.StudentCard.Series };

        //Student tmp = new Student
        //{
        //    FirstName = this.FirstName,
        //    LastName = this.LastName,
        //    Email = this.Email,
        //    BirthDate = this.BirthDate,
        //    StudentCard = new StudentCard { Id = this.StudentCard.Id, Series = this.StudentCard.Series}
        //};

        return tmp;
    }


    public int CompareTo(object? obj)
    {
        if (obj is Student)
        {
            return LastName.CompareTo((obj as Student).LastName);
        }
        throw new Exception("Can not compare objects");
    }

    public override string ToString()
    {
        return $"""
            Name:           {FirstName}
            Surname:        {LastName}
            Birthday:       {BirthDate.ToShortDateString()}
            Sdudent Card:   {StudentCard}

            """;
    }

}
