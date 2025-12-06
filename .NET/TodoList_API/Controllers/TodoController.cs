using Microsoft.AspNetCore.Mvc;
using TodoList_API.DBContext;
using TodoList_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoList_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoListDbContext todoListDbContext;

        public TodoController(TodoListDbContext todoListDbContext)
        {
            this.todoListDbContext = todoListDbContext;
        }
        // GET: api/<TodoController>
        [HttpGet]
        public IEnumerable<Todo> Get()
        {
            var todos = this.todoListDbContext.Todos.ToList();
            return todos;
        }

        // GET api/<TodoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TodoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var model = new Todo();
            model.Summary = value;
            model.Description = value;
            Console.WriteLine(model.Summary + model.Description);
        }

        // PUT api/<TodoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TodoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
