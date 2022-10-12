namespace FactoryPattern.Logistic;

public abstract class Logistic
{
    public void StartDelivery()
    {
        var transport = CreateTransport();
        transport.Deliver();
        Console.WriteLine("Logistic Dispatched");
    }

    protected abstract ITransport CreateTransport();
}
