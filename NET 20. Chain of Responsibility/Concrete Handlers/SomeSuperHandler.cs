class SomeSuperHandler : CompilerCoR
{
    public override void Handle()
    {
        // Some Super Pupper Mupper Logic
        // Some Super Pupper Mupper Logic
        // Some Super Pupper Mupper Logic
        // Some Super Pupper Mupper Logic
        Console.WriteLine("Super  handler worked");
        Next?.Handle();
    }
}

