using System.Collections.Generic;
using System.Threading.Tasks;

namespace todoapi
{
    public interface ITodoRepository
    {
        Task<IEnumerable<TodoDto>> GetAll();
        Task<TodoDto> Add(TodoDto todo);
    }
}