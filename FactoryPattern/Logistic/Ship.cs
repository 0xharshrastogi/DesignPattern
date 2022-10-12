namespace FactoryPattern.Logistic;

public class Ship : ITransport
{
    public void Deliver() => Console.WriteLine("Delivery by ship.");
}
