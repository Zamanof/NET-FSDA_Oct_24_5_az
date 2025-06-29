class WordLogistic : Logistic
{
    public override ITransport CreateTransport() => new Tongue();
}
