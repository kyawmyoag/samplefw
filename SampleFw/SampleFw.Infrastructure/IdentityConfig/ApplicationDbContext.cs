using Microsoft.AspNet.Identity.EntityFramework;
using SampleFw.Core;
using System.Data.Entity;

namespace SampleFw.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("SampleFwDBCS", throwIfV1Schema: false)
        {
            Database.SetInitializer(new EfDatabaseInitializer());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<ToDoEntity> ToDoEntities { get; private set; }


    }
}
