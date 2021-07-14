using CommandHelper.Models;
using System.Collections.Generic;

namespace CommandHelper.Repositories
{
    public interface ICommandRepository
    {
        bool SaveChanges();

        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id);

        void CreateCommand(Command command);
    }
}
