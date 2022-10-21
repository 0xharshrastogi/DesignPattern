using System.Collections;
namespace IteratorPattern.BinaryTree;

public class BFSEnumerator<T> : IEnumerator<T>, IEnumerable<T>
{
    private readonly Node<T>? _root;

    private Node<T>? _current;

    private Node<T>? _traversalCurrent;

    private readonly Stack<Node<T>> _stack = new();

    public T Current => _root is not null ? _root.Value : throw new Exception("Root Node Is Null");

    object IEnumerator.Current => Current!;

    public BFSEnumerator(Node<T>? root)
    {
        _root = root;
        _current = root;
        _traversalCurrent = root;
    }

    public bool MoveNext()
    {
        // reach the most left node
        Console.WriteLine($"_traversalCurrent is null  {_traversalCurrent is null}");
        while (_traversalCurrent is not null)
        {
            _stack.Push(_traversalCurrent);
            _traversalCurrent = _traversalCurrent.Left;
        }

        // current is null now
        if (_stack.Count is not 0)
        {
            _current = _stack.Peek();
            _stack.Pop();

            _traversalCurrent = _current.Right;
        }
        // Console.WriteLine(_stack.Count);
        return _stack.Count is not 0;
    }

    public void Reset()
    {
        _current = _root;
        _traversalCurrent = _root;
    }

    public void Dispose() => GC.SuppressFinalize(this);

    public IEnumerator<T> GetEnumerator() => this;
    IEnumerator IEnumerable.GetEnumerator() => this;
}
