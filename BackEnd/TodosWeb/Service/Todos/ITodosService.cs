using TodosWeb.Models;

namespace TodosWeb.Service.Todos
{
    public interface ITodosService
    {
        List<Todo> GetTodos();

        Boolean AddTodo(Todo todo);

        Boolean UpdateTodo(Todo todo);

        Boolean DelTodo(Todo toddo);
    }
}
