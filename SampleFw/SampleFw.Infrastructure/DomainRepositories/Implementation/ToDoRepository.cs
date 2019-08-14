using SampleFw.Core;
using System.Collections.Generic;
using System.Linq;

namespace SampleFw.Infrastructure
{
    public class ToDoRepository : GenericRepository<ToDoEntity>, IToDoRepository
    {
        private readonly ApplicationDbContext dbContext;

        public IEnumerable<ToDoEntity> GetToDoEntities(string toDoName)
        {
            return dbContext.ToDoEntities.Where(x => x.ToDoName.ToLower() == toDoName.ToLower());
        }
    }
}
