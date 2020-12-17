using Microsoft.EntityFramworkCore;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options)
            : base(options) 
        {

        }

        public DbSet<Command> CommandItems { get; set; }
    }
}