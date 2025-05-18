// class
// internal - yalniz elen edildiyi assembly daxilinde elchatandir
// public - istenilen assembly daxilinde elchatandir
public class Human
{
    #region access modifiers
    // private   - yalniz class daxilinde elchatandir
    // public    - istenilen yerde elchatandir
    // protected - class-in daxilinde ve toremish class-larda elchatandir. class xaricinde elchatan deyil
    // internal - yalniz bizim assembly daxilinde elchatandir
    // protected internal - yalniz bizim assembly daxilinde tireyen class-larda elchatandir
    #endregion


    public string name;
    public string surname;
    public int age;

    // static field butun class uchun bir instance(numune) olur ve class-in adindan chaqrila bilir
    public static int count;

    // const field - static field-dei butun class uchun bir instance(numune) olur
    // ve class-in adindan chaqrila bilir. qiymeti deyishdirile bilmir
    public const int field1 = 265;

    // readonly field - C++-dan bildiyimiz const mentiqi ile ishleyir
    public readonly int field2 = 456;

    public Human(string name, string surname, int age)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
    }

    public Human()
        :this("John", age: 18, surname:"Doe")
        // constructor-larin deleqasiyasi
    {}

    public Human(int field2, string name, string surname, int age)
        :this(name, surname, age)
    {
        this.field2 = field2;
    }

    // static constructor static field-leri initialize etmek uchun istifade edilir
    static Human()
    {
        count = 0;
    }
    void Foo()
    {
        // field2 = 24; deyeri deyishdirmek olmaz
    }

    // maksimum dercede method-larin daxilinde her hansi platformaya baqli methodlar istifade etmeyin
    // Meselen Show methodunun daxilinde Console-a baqliliq var
    public void Show()
    {
        Console.WriteLine(@$"Name:    {name}
Surname: {surname}
Age:     {age}");
    }

    public string Info()
    {
        return @$"Name:    {name}
Surname: {surname}
Age:     {age}";
    }

    public override string ToString()
    {
        return @$"Name:    {name}
Surname: {surname}
Age:     {age}
";
    }

    // Finalizer - obyekt "olende" chaqirilan method-dur
    // !!!DESTRUCTOR DEYIL!!!
    ~Human()
    {

    }
}
