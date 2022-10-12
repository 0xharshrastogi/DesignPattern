using FactoryPattern.Logistic;

namespace FactoryPattern;

internal static class Program
{
    private const string LogisticFlag = "--logistic";

    private static void Main(string[] args)
    {
        var logisticType = ExtractLogisticTypeFrom(args);

        new LogisticBuilder(logisticType)
            .BuildLogistic()
            .StartDelivery();
    }

    private static LogisticType ExtractLogisticTypeFrom(string[] args)
    {
        var logisticFlagNotFoundException = new Exception("Cannot Find Flag [--logistic=land|ship] in args");

        if (args.Length is 0) throw logisticFlagNotFoundException;

        var value = Array.Find(args, arg => arg.StartsWith(LogisticFlag))?.Split("=")[1] ?? throw logisticFlagNotFoundException;

        try
        {
            return Enum.Parse<LogisticType>(value, ignoreCase: true);
        }
        catch (Exception err)
        {
            throw new Exception($"{value} is not a valid value for [--logistic=land|ship]", err);
        }
    }
}
