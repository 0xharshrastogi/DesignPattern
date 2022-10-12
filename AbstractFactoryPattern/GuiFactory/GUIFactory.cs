namespace AbstractFactoryPattern.GuiFactory;

public abstract class GUIFactory
{
    public abstract Button CreateButton();

    public abstract Dialog CreateDialog();
}
