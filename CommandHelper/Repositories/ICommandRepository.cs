using CommandHelper.Models;
using System.Collections.Generic;

namespace CommandHelper.Repositories
{
    public interface ICommandRepository
    {
        IEnumerable<Command> GetAllCommands();

        Command GetCommandById(int id);
    }
}
