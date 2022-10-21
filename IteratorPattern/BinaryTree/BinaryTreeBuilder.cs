namespace IteratorPattern.BinaryTree;

public class BinaryTreeBuilder<T>
{
    private readonly IComparer<T> _comparable;

    private Node<T>? _root;

    private readonly List<T> _values = new();

    public BinaryTreeBuilder(IComparer<T> comparable)
    {
        _comparable = comparable;
    }

    public bool IsLeafNode(Node<T> node) => (node.Left is null) && (node.Right is null);

    public BinaryTreeBuilder<T> Add(T value)
    {
        _values.Add(value);
        return this;
    }

    public void Insert(T value)
    {
        if (_root is null)
        {
            _root = new Node<T>(value);
            return;
        }

        var current = _root;
        while (current is not null)
        {
            int? result = _comparable.Compare(value, current.Value);
            var parent = current;
            current = result < 0 ? current.Left : current.Right;

            if (current is null)
            {
                if (result < 0) parent.Left = new Node<T>(value);
                else parent.Right = new Node<T>(value);
            }
        }
    }

    public Node<T>? Build()
    {
        _values.ForEach(value => Insert(value));
        return _root;
    }
}
