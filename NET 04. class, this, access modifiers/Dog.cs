// primary constructor - new in C# 12
// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/primary-constructors
class Dog(string name, int age, float price) {
    public int some;

    public override string ToString()
    {
        return $@"Name: {name}, Age: {age}, Price: {price}";
    }
}