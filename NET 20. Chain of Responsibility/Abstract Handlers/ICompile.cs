// Chain of Responsibility - CoR
interface ICompile
{
    CompilerCoR SetNext(CompilerCoR nextHandler);
    void Handle();
}
