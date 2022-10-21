namespace IteratorPattern;

public class BinaryTreeNumberComparer : IComparer<int>
{
    public int Compare(int x, int y) => x <= y ? -1 : 1;
}
