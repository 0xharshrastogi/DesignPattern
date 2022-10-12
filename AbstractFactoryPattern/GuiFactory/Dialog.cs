namespace AbstractFactoryPattern.GuiFactory;

public abstract class Dialog
{
    public event Action? OnClose;

    public event Action? OnOpen;

    public bool IsActive { get; private set; }

    public bool IsClosed => !IsActive;

    public bool IsOpen => IsActive;

    public virtual void Close()
    {
        if (IsClosed) return;

        IsActive = false;
        if (OnClose is not null) OnClose();
    }

    public virtual void Open()
    {
        if (IsOpen) return;

        IsActive = true;
        if (OnOpen is not null) OnOpen();
    }
}
