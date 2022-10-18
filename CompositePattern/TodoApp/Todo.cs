using CompositePattern.HtmlRendrer;

namespace CompositePattern.TodoApp;

public class Todo
{
    public bool IsCompleted { get; set; }

    public string? Title { get; set; }
}

public class TodoComponent : Component
{
    private readonly Todo _todo;

    public TodoComponent(Todo todo)
    {
        _todo = todo;
    }

    public override string Render()
    {
        var isChecked = _todo.IsCompleted ? "true" : "false";
        return @$"<input type=""checkbox"" checked={isChecked}/> {_todo.Title}";
    }
}

public class TodoListComponent : Component
{
    public IEnumerable<Todo> Todos { get; set; }

    public TodoListComponent()
    {
        Todos = new List<Todo>
        {
            new Todo { IsCompleted = false, Title = "Test Item 1" },
            new Todo { IsCompleted = false, Title = "Test Item 2" },
            new Todo { IsCompleted = false, Title = "Test Item 3" },
            new Todo { IsCompleted = false, Title = "Test Item 4" },
            new Todo { IsCompleted = false, Title = "Test Item 5" },
            new Todo { IsCompleted = false, Title = "Test Item 6" },
            new Todo { IsCompleted = false, Title = "Test Item 7" }
        };
    }

    public override string Render()
    {
        var value = string.Concat(Todos.Select(todo => $"<li>{new TodoComponent(todo)}</li>"));

        return string.Format(
@$"<h1>Hello World<h1>
    <ul>
        {value}
    </ul>
");
    }
}
