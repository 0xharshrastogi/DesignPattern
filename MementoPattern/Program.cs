using MementoPattern.Editor;

var snapshotsStack = new Stack<Snapshot>();
var editor = new Editor();

var moveCursor = (int x, int y) =>
{
    var cmd = new Command(editor, () => editor.SetCursor(x, y));
    var snapshot = cmd.Backup();
    cmd.Execute();
    snapshotsStack.Push(snapshot);
};

var makeText = (string text) =>
{
    var cmd = new Command(editor, () => editor.Text = text);
    var snapshot = cmd.Backup();
    cmd.Execute();
    snapshotsStack.Push(snapshot);
};

Console.WriteLine(editor);
moveCursor(10, 10);
Console.WriteLine(editor);
makeText("Today is Friday");
Console.WriteLine(editor);

var previousSnapshot = snapshotsStack.Pop();
previousSnapshot = snapshotsStack.Pop();
previousSnapshot.Restore();

Console.WriteLine(editor);
