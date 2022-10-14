namespace AdapterPattern;

public class AndroidPhone : IMicroUsbPhone
{
    private bool _isConnected;

    public void Recharge()
    {
        if (!_isConnected)
        {
            Console.WriteLine("Connect MicroUSB Charger First");
            return;
        }

        Console.WriteLine("Recharge Started");
        Thread.Sleep(1_000);
        Console.WriteLine("Recharge Completed");
    }

    public void UseMicroUSB()
    {
        _isConnected = true;
        Console.WriteLine("MicroUSB Connected");
    }
}
