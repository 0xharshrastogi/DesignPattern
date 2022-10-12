namespace AbstractFactoryPattern.GuiFactory.Macbook;

internal class MacGUIFactory : GUIFactory
{
    public override Button CreateButton() => new MacButton();

    public override Dialog CreateDialog() => new MacDialog();
}
