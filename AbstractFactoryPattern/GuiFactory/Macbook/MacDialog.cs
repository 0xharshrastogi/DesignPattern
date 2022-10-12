namespace AbstractFactoryPattern.GuiFactory.Macbook;

public class MacDialog : Dialog
{
    public MacDialog()
    {
        OnOpen += () => Console.WriteLine("Macbook Dialog Opened");
        OnClose += () => Console.WriteLine("Macbook Dialog Closed");
    }
}
