// Chain of Responsibility - CoR
class Linker : CompilerCoR
{
    public override void Handle()
    {
        // some magic code
        Console.WriteLine("Linker Analyzer");
        Next?.Handle();
    }
}