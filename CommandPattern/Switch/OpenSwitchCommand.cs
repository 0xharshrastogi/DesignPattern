namespace CommandPattern.Switch;

/// <summary>
/// The Command for turning on the device
/// </summary>
public class OpenSwitchCommand : ICommand
{
    private readonly ISwitchable _switchable;

    public OpenSwitchCommand(ISwitchable switchable)
    {
        _switchable = switchable;
    }

    public void Execute() => _switchable.Enable();
}
