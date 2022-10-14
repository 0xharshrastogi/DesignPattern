namespace AdapterPattern;
internal class Program
{
    private static void RechargeLightningPhone(ILightningPhone phone)
    {
        phone.UseLightening();
        phone.Recharge();
    }

    private static void RechargeMicroUsbPhone(IMicroUsbPhone phone)
    {
        phone.UseMicroUSB();
        phone.Recharge();
    }

    public static void Main()
    {
        var android = new AndroidPhone();
        var iphone = new ApplePhone();

        RechargeLightningPhone(iphone);
        RechargeMicroUsbPhone(android);

        RechargeMicroUsbPhone(new LightningToMicroUsbAdapter(iphone));
        RechargeLightningPhone(new MicroUsbToLightningAdapter(android));
    }
}
