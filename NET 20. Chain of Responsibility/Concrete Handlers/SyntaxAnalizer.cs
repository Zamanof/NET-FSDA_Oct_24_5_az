// Chain of Responsibility - CoR
class SyntaxAnalizer : CompilerCoR
{
    public override void Handle()
    {
        // some magic code
        Console.WriteLine("Syntax Analyzer");
        Next?.Handle();
    }
}
