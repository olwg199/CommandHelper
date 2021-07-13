using CommandHelper.Models;
using System.Collections.Generic;
using System.Linq;

namespace CommandHelper.Repositories
{
    public class CommandRepository : ICommandRepository
    {
        private readonly CommandHelperDbContext _context;

        public CommandRepository(CommandHelperDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(c=>c.Id == id);
        }
    }
}
