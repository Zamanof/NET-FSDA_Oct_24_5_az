// primary constructor -> new in C# 12
// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/primary-constructors



#region classic constructor
//Dog dog = new("Toplan", 5, 5.5f);
//dog.Print();
//class Dog
//{
//    string name;
//    int age;
//    float price;

//    // classic constructor
//    public Dog(string name, int age, float price)
//    {
//        this.name = name;
//        this.age = age;
//        this.price = price;
//    }
//    public void Print()
//    {
//        Console.WriteLine($"{name} {age} {price}");
//    }
//}
#endregion

#region primary constructor
Dog dog = new("Toplan", 5, 5.5f);
dog.Print();

class Dog(string name, int age, float price)
{
    public void Print()
    {
        Console.WriteLine($"{name} {age} {price}");
    }
}

#endregion