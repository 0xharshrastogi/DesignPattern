namespace AbstractFactoryPattern.GuiFactory.Windows;

public class WinDialog : Dialog
{
    public WinDialog()
    {
        OnOpen += () => Console.WriteLine("Window Dialog Opened");
        OnClose += () => Console.WriteLine("Window Dialog Closed");
    }
}
