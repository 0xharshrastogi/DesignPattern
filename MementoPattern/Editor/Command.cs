namespace MementoPattern.Editor;

public class Command
{
    private Snapshot? _snapshot;
    private readonly Editor _editor;

    private readonly Action _action;

    public Command(Editor editor, Action action)
    {
        _editor = editor;
        _action = action;
    }

    public void Execute() => _action.Invoke();

    public Snapshot Backup() => _snapshot = _editor.CreateSnapshot();

    public void Restore() => _snapshot?.Restore();
}
