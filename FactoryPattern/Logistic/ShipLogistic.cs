namespace FactoryPattern.Logistic;

public class ShipLogistic : Logistic
{
    protected override ITransport CreateTransport() => new Ship();
}
