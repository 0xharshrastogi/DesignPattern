namespace AbstractFactoryPattern.GuiFactory;

public abstract class Button
{
    public event Action? OnClick;

    public virtual void Click()
    {
        if (OnClick is null) return;
        OnClick();
    }
}
