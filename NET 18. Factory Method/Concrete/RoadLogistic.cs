class RoadLogistic : Logistic
{
    public override ITransport CreateTransport() => new Truck();
}
