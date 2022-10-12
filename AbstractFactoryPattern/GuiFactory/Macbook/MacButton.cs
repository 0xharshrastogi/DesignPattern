namespace AbstractFactoryPattern.GuiFactory.Macbook;

public class MacButton : Button
{
    public override void Click()
    {
        Console.WriteLine("Macbook Button Clicked");
        base.Click();
    }
}
