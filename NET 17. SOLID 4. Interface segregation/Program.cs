// Interface segregation


#region Bad example
//abstract class Animal
//{
//    public abstract void Feed();
//    public abstract void Groom();
//}

//class Dog : Animal
//{
//    public override void Feed()
//    {
//        Console.WriteLine("Dog feed");
//    }

//    public override void Groom()
//    {
//        Console.WriteLine("Dog groom");
//    }
//}

//class Cat : Animal
//{
//    public override void Feed()
//    {
//        Console.WriteLine("Cat feed");
//    }

//    public override void Groom()
//    {
//        Console.WriteLine("Cat groom");
//    }
//}

//class Tiger : Animal
//{
//    public override void Feed()
//    {
//        Console.WriteLine("Tiger feed");
//    }

//    public override void Groom()
//    {
//        throw new NotImplementedException();
//    }
//}
#endregion

#region Good example
abstract class Animal
{}

interface IFeed
{
    public void Feed();

}
interface IGroom
{
    public void Groom();
}

interface IPet: IFeed, IGroom
{}

class Dog : Animal, IFeed, IGroom
{
    public void Feed()
    {
        Console.WriteLine("Dog feed");
    }

    public void Groom()
    {
        Console.WriteLine("Dog groom");
    }
}

class Cat : Animal, IPet
{
    public void Feed()
    {
        Console.WriteLine("Cat feed");
    }

    public void Groom()
    {
        Console.WriteLine("Cat groom");
    }
}

class Tiger : Animal, IFeed
{
    public void Feed()
    {
        Console.WriteLine("Tiger feed");
    }
}
#endregion