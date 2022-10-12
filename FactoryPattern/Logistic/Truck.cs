namespace FactoryPattern.Logistic;

public class Truck : ITransport
{
    public void Deliver() => Console.WriteLine("Delivery by truck.");
}
