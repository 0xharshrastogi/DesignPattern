namespace AbstractFactoryPattern.GuiFactory.Windows;

public class WinGUIFactory : GUIFactory
{
    public override Button CreateButton() => new WinButton();

    public override Dialog CreateDialog() => new WinDialog();
}
