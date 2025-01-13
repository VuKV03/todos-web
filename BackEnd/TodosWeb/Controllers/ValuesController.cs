using Microsoft.AspNetCore.Mvc;
using TodosWeb.Data;
using TodosWeb.Models;
using TodosWeb.Service.Todos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodosWeb.Controllers
{
    [Route("v1/api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodosService _todosService;

        public TodosController(ITodosService todosService)
        {
            _todosService = todosService;
        } 
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_todosService.GetTodos());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post(Todo todo)
        {
            return Ok(_todosService.AddTodo(todo));
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            return Ok(_todosService.DelTodo(id));
        }
    }
}
