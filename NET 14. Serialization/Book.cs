// Serialization

public class Book
{
    public Guid Id;
    public Author Author { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public Book()
    {
        Id = Guid.NewGuid();
    }

    public override string ToString()
    {
        return $"""
        Id:         {Id}
        Titile:     {Title}
        Price:      {Price}
        Author:     {Author}

""";
    }
} 

