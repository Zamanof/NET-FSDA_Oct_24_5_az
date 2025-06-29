// Factory method

Logistic logistic = new RoadLogistic();
Deliver(logistic, "Mercedes-AMG G 63 6x6");
Deliver(new WordLogistic(), "Xeberin var? Filankesin oqlu Mercedes-AMG G 63 6x6 alib");

void Deliver(Logistic logistic, string productName)
{
    var transport = logistic.CreateTransport();
    transport.Deliver(productName);
}
