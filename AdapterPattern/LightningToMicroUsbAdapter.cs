namespace AdapterPattern;

public class LightningToMicroUsbAdapter : IMicroUsbPhone
{
    private readonly ILightningPhone _phone;

    public LightningToMicroUsbAdapter(ILightningPhone phone)
    {
        _phone = phone;
    }

    public void Recharge() => _phone.Recharge();

    public void UseMicroUSB()
    {
        Console.WriteLine("Connected MicroUsb");
        _phone.UseLightening();
    }
}
