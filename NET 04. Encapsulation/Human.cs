// Encapsulation, properties
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
class Human
{
    public string name;
    public string surname;
    private int age;

    public int GetAge()
    {
        return age;
    }
    public void SetAge(int age)
    {
        if (age > 0)
        {
            this.age = age;
        }
        else
        {
            throw new ArgumentException("Menfi qiymet vermek olmaz");
        }
    }
    // properties
    // auto-property
    public string GroupName { private get; set; } = "FSDA_Oct_24_5_az";
    /*
     public string GroupName { get; set; };

    eslinde altinda bele bir code yaranir: 
    
    kichik herfle private field ve iki method: get ve set
     
    private string groupName;    

    public float GroupName
    {
        get { return groupName; }
        set { groupName = value; }
    }
     */
    // full-property
    private float mark;

    public float Mark
    {
        get { return mark; }
        set {
            if (value < 0) { throw new Exception("Menfi deyer olmaz"); }
            mark = value; 
        }
    }

    //public float get_Mark()
    //{
    //    return mark;
    //}
    //public void set_Mark(float value)
    //{

    //}
    public Human(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        if (age > 0)
        {
            this.age = age;
        }
        else
        {
            throw new ArgumentException("Menfi qiymet vermek olmaz");
        }
    }

    public override string ToString()
    {
        return @$"Name:    {name}
Surname: {surname}
Age:     {age}
";
    }
}
