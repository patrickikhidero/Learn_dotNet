using System.Collections.Generic;
using CommandsApi.Models;

namespace CommandsApi.Data
{
public class MockCommandsRepo : ICommandsRepo
{
    public IEnumerable<Commands> GetAllCommands()
    {
        var commands = new List<Commands>
        {
            new Commands { Id = 0, HowTo = "How to boil yam", Line = "Line 1", Platform = "Kitchen" },
            new Commands { Id = 1, HowTo = "How to fry egg", Line = "Line 2", Platform = "Restaurant" },
            new Commands { Id = 2, HowTo = "How to Dance salsa", Line = "Line 3", Platform = "Party" },
            new Commands { Id = 3, HowTo = "How to buy house without money", Line = "Line 4", Platform = "Real Estate" },
            new Commands { Id = 4, HowTo = "How to buy land with 1k", Line = "Line 5", Platform = "Lagos" },
        };
        return commands;
    }

    public Commands GetCommandById(int id)
    {
        return new Commands
        {
            Id = 1,
            HowTo = "How to do something",
            Line = "do something",
            Platform = "Platform"
        };
    }
}
}