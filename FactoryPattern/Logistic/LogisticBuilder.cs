namespace FactoryPattern.Logistic;

public class LogisticBuilder : ILogisticBuilder
{
    private readonly LogisticType _logisticType;

    public LogisticBuilder(LogisticType logisticType)
    {
        _logisticType = logisticType;
    }

    public Logistic BuildLogistic() => _logisticType switch
    {
        LogisticType.Ship => new ShipLogistic(),
        LogisticType.Truck => new TruckLogistic(),
        _ => throw new Exception($"{_logisticType} Builder not implemented"),
    };
}
