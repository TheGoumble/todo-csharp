namespace Services;

public interface ITodoServices
{
    List<Todo> GetAll();
    Todo Create(string title);
}
public class TodoServices : ITodoServices
{
    private List<Todo> _todos = new List<Todo>();
    public Todo Create(string title)
    {
        var todo = new Todo { Title = title, IsConpleted = false };
        _todos.Add(todo);
        return todo;
    }

    public List<Todo> GetAll()
    {
      return _todos;
    }
}