namespace MementoPattern.Editor;

public class Editor
{
    public string? Text { get; set; }

    private (int PosX, int PosY) _cursor;

    public float SelectionWidth { get; set; }

    public void SetCursor(int x, int y) => _cursor = (x, y);

    public Snapshot CreateSnapshot() => new(this, Text, _cursor, SelectionWidth);

    public override string ToString() => $"Editor Snapshot At [{DateTime.Now:t}]\n\nText: {Text ?? "NO_TEXT_PRESENT"}\nCursor: ({_cursor.PosX}, {_cursor.PosY})\nSelection Width: {SelectionWidth}\n";
}
