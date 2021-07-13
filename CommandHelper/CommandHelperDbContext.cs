using CommandHelper.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandHelper
{
    public class CommandHelperDbContext : DbContext
    {
        public CommandHelperDbContext(DbContextOptions<CommandHelperDbContext> opt) : base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}
