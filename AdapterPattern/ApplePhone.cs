namespace AdapterPattern;

public class ApplePhone : ILightningPhone
{
    private bool _isConnected;

    public void Recharge()
    {
        if (!_isConnected)
        {
            Console.WriteLine("Connect Lightning Charger First");
            return;
        }

        Console.WriteLine("Recharge Started");
        Thread.Sleep(1_000);
        Console.WriteLine("Recharge Completed");
    }

    public void UseLightening()
    {
        _isConnected = true;
        Console.WriteLine("Lightning Connected");
    }
}
