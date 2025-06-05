class Student
{
    public uint Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public uint Age { get; set; }
    public uint GroupId { get; set; }
    static uint idCounter = 1;
    public override string ToString()
    {
        return $"""
            Id:         {Id} 
            FirstName:  {FirstName} 
            LastName:   {LastName} 
            Age:        {Age} 
            GroupId:    {GroupId}

            """;
    }
    public Student()
    {
        Id = idCounter++;
    }

}
