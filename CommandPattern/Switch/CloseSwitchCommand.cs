namespace CommandPattern.Switch;

/// <summary>
/// The Command for turning off the device
/// </summary>
public class CloseSwitchCommand : ICommand
{
    private readonly ISwitchable _switchable;

    public CloseSwitchCommand(ISwitchable switchable)
    {
        _switchable = switchable;
    }

    public void Execute() => _switchable.Disable();
}
