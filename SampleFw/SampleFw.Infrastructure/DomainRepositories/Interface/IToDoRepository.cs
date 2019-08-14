using SampleFw.Core;
using System.Collections.Generic;

namespace SampleFw.Infrastructure
{
    public interface IToDoRepository : IGenericRepository<ToDoEntity>
    {
        IEnumerable<ToDoEntity> GetToDoEntities(string toDoName);
    }
}
