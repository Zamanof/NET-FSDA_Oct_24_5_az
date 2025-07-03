// Chain of Responsibility - CoR
abstract class CompilerCoR : ICompile
{
    protected CompilerCoR Next { get; set; }
    public CompilerCoR SetNext(CompilerCoR nextHandler)
    {
        Next = nextHandler;
        return this;
    }
    public abstract void Handle();
}
