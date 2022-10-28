namespace MementoPattern.Editor;

public class Snapshot
{
    private readonly Editor _editor;

    private readonly string? _text;
    private readonly (int PosX, int PosY) _cursor;

    private readonly float _selectionWidth;

    public Snapshot(Editor editor, string? text, (int PosX, int PosY) cursor, float selectionWidth)
    {
        _editor = editor;
        _text = text;
        _cursor = cursor;
        _selectionWidth = selectionWidth;
    }

    public void Restore()
    {
        _editor.Text = _text;
        _editor.SetCursor(_cursor.PosX, _cursor.PosY);
        _editor.SelectionWidth = _selectionWidth;
    }
}
