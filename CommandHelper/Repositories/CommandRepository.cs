using CommandHelper.Models;
using System.Collections.Generic;

namespace CommandHelper.Repositories
{
    public class CommandRepository : ICommandRepository
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, Description = "Boil eggs", CMDSnippet = "Boil water", Platform = "Kettle&Pen" },
                new Command { Id = 0, Description = "Cut bread", CMDSnippet = "Get a knife", Platform = "Knife&chopping board" },
                new Command { Id = 0, Description = "Make cup of tea", CMDSnippet = "Place teabag in cup", Platform = "Kettle&cup" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, Description = "Boil eggs", CMDSnippet = "Boil water", Platform = "Kettle&Pen" }
        }
    }
}
