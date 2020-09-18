using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace todoapi.Controllers
{
    [ApiController]
    [Route("todo")]
    public class TodoController : ControllerBase
    {
        private readonly ILogger<TodoController> _logger;
        private ITodoRepository _repositorio;

        public TodoController(ILogger<TodoController> logger, ITodoRepository repositorio)
        {
            _logger = logger;
            _repositorio = repositorio;
        }

        public async Task<IEnumerable<TodoDto>> Get()
        {
            _logger.LogInformation("Get recebido");
            return await _repositorio.GetAll();
        }

        [HttpDelete]
        public void Delete()
        {
            _logger.LogInformation("Delete recebido");
        }

        [HttpPost]
        public async Task<TodoDto> Post(TodoDto todo)
        {
            _logger.LogInformation("Post recebido: " + todo.Title);
            return await _repositorio.Add(todo);
        }
    }
}
