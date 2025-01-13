using TodosWeb.Data;
using TodosWeb.Models;

namespace TodosWeb.Service.Todos
{
    public class TodosService : ITodosService
    {

        private readonly TodosDbContext _todosDbContext;

        public TodosService (TodosDbContext todosDbContext)
        {
            _todosDbContext = todosDbContext;
        }
        public bool AddTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public bool DelTodo(int id)
        {
            Todo todo = _todosDbContext.Todos.Find(id);
            _todosDbContext.Todos.Remove(todo);
            _todosDbContext.SaveChanges();
            return true;
        }

        public List<Todo> GetTodos()
        {
            return _todosDbContext.Todos.OrderByDescending(x => x.Id).ToList();
        }

        public bool UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
