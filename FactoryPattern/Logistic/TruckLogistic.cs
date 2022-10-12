namespace FactoryPattern.Logistic;

public class TruckLogistic : Logistic
{
    protected override ITransport CreateTransport() => new Truck();
}
