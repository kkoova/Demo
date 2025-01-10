using DemoO.Models;
using System.Data;
using System.Data.Entity;

namespace DemoOne.Entity
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base ("MyUserContext") 
        {
            Database.SetInitializer<MyDbContext>(null);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
