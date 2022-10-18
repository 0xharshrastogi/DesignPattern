namespace CompositePattern.HtmlRendrer;

public abstract class Component
{
    public abstract string Render();

    public sealed override string ToString() => Render();
}
