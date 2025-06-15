// Serialization

using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

Author author = new Author("Joseph", "Albahary");

Book book = new Book()
{
    Author = author,
    Title = "C#13 in a Nutshell",
    Description = "Full guide for C# Language",
    Price = 125.50
};

List<Book> books = new List<Book>()
{
    book,
    new Book()
    {
        Author = new Author("Jeffrey", "Richter"),
        Title = "C# vi CLR",
        Description = "Super pupper nupper book",
        Price = 256.63
    },
    new Book()
    {
        Author = new Author("Rovshan", "Abdullaoqlu"),
        Title = "Bu sheherde kimse yoxdur",
        Description = "Chox mohteshem eser",
        Price = 1256.36
    }
};

#region XML Serializaion

#region single object serializtion
//XmlSerializer serializer = new XmlSerializer(typeof(Book));
// write to XML file
//using var file = new FileStream("book.xml", FileMode.OpenOrCreate);
//serializer.Serialize(file, book);

// read to XML file
//using var file = new FileStream("book.xml", FileMode.Open);
//var result = serializer.Deserialize(file) as Book;
//Console.WriteLine(result);
#endregion

#region list of objects serializtion
//XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
// write to XML file
//using var file = new FileStream("books.xml", FileMode.OpenOrCreate);
//serializer.Serialize(file, books);

// read to XML file
//using var file = new FileStream("books.xml", FileMode.Open);
//var results = serializer.Deserialize(file) as List<Book>;
//results.ForEach(Console.WriteLine);
#endregion

#endregion


#region JSON Serializaion
//using var file = new FileStream("book.json", FileMode.OpenOrCreate);

//JsonSerializerOptions options = new JsonSerializerOptions();
//options.WriteIndented = true;

////var json = JsonSerializer.Serialize(book, options);
////Console.WriteLine(json);

//JsonSerializer.Serialize(file, book, options);


//using var file = new FileStream("book.json", FileMode.Open);
//var result = JsonSerializer.Deserialize<Book>(file);
//Console.WriteLine(result);



//using var file = new FileStream("books.json", FileMode.OpenOrCreate);

JsonSerializerOptions options = new JsonSerializerOptions();
options.WriteIndented = true;

var json = JsonSerializer.Serialize(books, options);
Console.WriteLine(json);

//JsonSerializer.Serialize(file, books, options);


//using var file = new FileStream("books.json", FileMode.Open);
//var results = JsonSerializer.Deserialize<List<Book>>(file);
//results!.ForEach(Console.WriteLine);
#endregion