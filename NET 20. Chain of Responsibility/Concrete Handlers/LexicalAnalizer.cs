// Chain of Responsibility - CoR
class LexicalAnalizer : CompilerCoR
{
    public override void Handle()
    {
        // some magic code
        //return;
        Console.WriteLine("Lexical Analyzer");
        Next?.Handle();
    }
}
