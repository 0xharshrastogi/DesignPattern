namespace CommandPattern.Switch;

/// <summary>
/// Invoker Class
/// </summary>
public class Switch
{
    private readonly ICommand _openCmd;

    private readonly ICommand _closeCommand;

    public Switch(ICommand openCommand, ICommand closeCommand)
    {
        _openCmd = openCommand;
        _closeCommand = closeCommand;
    }

    public void Open() => _openCmd.Execute();

    public void Close() => _closeCommand.Execute();
}
