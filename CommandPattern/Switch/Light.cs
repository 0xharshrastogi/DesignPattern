namespace CommandPattern.Switch;

/// <summary>
/// Concrete Receiver Class
/// </summary>
public class Light : ISwitchable
{
    public void Disable() => Console.WriteLine("Light Bulb Is Off");

    public void Enable() => Console.WriteLine("Light Bulb Is On");
}
