using SampleFw.Core;
using System.Collections.Generic;
using System.Data.Entity;

namespace SampleFw.Infrastructure
{
    public class EfDatabaseInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            //ToDoList Seed Data
            List<ToDoEntity> toDoEntities=new List<ToDoEntity>()
            {
                new ToDoEntity(){ ToDoName ="ToDoName1", ToDoDescription="ToDoDescription1" },
                new ToDoEntity(){ ToDoName ="ToDoName2", ToDoDescription="ToDoDescription2" },
            };
            
            context.ToDoEntities.AddRange(toDoEntities);

            base.Seed(context);
        }
    }
}
