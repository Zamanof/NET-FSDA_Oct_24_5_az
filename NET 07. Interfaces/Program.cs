// Abstract class - is elaqesidir ve mensubiyyeti bildirir
// class-dan toreyirik(inheritance) ve yalniz bir class-dan toremek mumkundur

// Abstract class-in abstract metodunu realizasiya etmemek de olar
// - bu zaman toreyen classin ozunu de abstract etmeliyik


// Interface - do something (bacariq bildirir) 
// interface ise realizasiya olunur(implementation)
// ve eyni anda istenilen qeder interface-i realizasiya etmek olar

// Interface bir contract(muqaviledir) ve mutleq implementation olunmalidir

// Interface-le baqli bir neche qayda:
// Interface-in ichinde sade field yaratmaq mumkun deyil, amma property yaratmaq mumkundur
// Interface-in ichindeki property-ler ve method descriptionlar public olur

#region Interface

// Interface reference
IWalk walkObject = new Student();

Bar(walkObject);
Bar(new Cat());
Foo(new AI());
Foo(new Student());
Foo(new Cat());

void Foo(IThink thinker)
{
    thinker.Think();
}

void Bar(IWalk walker)
{
    walker.Walk();
}

abstract class Human
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}

interface IThink
{
    void Think();
}

interface IWalk
{
    void Walk();
}

interface IHomoSapiens: IThink, IWalk
{}

class Student : Human, IHomoSapiens
{
    public float[] Marks {  get; set; }
    public void Think()
    {
        Console.WriteLine("I think like student");
    }

    public void Walk()
    {
        Console.WriteLine("I walk like Human");
    }
}

class AI : IThink
{
    public void Think()
    {
        Console.WriteLine("I think like AI");
    }
}
class Cat : IWalk, IThink
{
    public void Think()
    {
        Console.WriteLine("I think about yemek");
    }

    public void Walk()
    {
        Console.WriteLine("I walk like Cat");
    }
}

#endregion

// VACIB olaraq arashdirin, oxuyun. Novbeti dersde suallar vercem: 

// Abstract class vs Interface

// delegates