using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace todoapi
{
    public class TodoRepository : ITodoRepository
    {
        private ConcurrentBag<TodoDto> colecao;
        public TodoRepository()
        {
            colecao = new ConcurrentBag<TodoDto>();
        }
        public async Task<TodoDto> Add(TodoDto todo)
        {
            colecao.Add(todo);
            return todo;
        }

        public async Task<IEnumerable<TodoDto>> GetAll()
        {
            return colecao.OrderBy(t => t.Title).ToList();
        }
    }
}