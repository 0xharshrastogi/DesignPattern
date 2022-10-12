namespace AbstractFactoryPattern.GuiFactory.Windows;

public class WinButton : Button
{
    public override void Click()
    {
        Console.WriteLine("Window Button Clicked");
        base.Click();
    }
}
