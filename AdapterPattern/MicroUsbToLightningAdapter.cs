namespace AdapterPattern;

public class MicroUsbToLightningAdapter : ILightningPhone
{
    private readonly IMicroUsbPhone _phone;

    public MicroUsbToLightningAdapter(IMicroUsbPhone phone)
    {
        _phone = phone;
    }

    public void Recharge() => _phone.Recharge();

    public void UseLightening()
    {
        Console.WriteLine("Connected MicroUsb");
        _phone.UseMicroUSB();
    }
}
