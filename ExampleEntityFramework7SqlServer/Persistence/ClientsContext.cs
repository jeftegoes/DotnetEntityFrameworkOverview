using ExampleEntityFramework7SqlServer.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExampleEntityFramework7SqlServer.Persistence
{
    public class ClientsContext : DbContext
    {
        public DbSet<Client> Client { get; set; }

        public ClientsContext(DbContextOptions options) : base(options)
        {

        }
    }
}