using Microsoft.EntityFrameworkCore;
using WebApi_Application.Models;

namespace WebApi_Application.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }

        public DbSet<Command> Commands {get; set;}
    }
}