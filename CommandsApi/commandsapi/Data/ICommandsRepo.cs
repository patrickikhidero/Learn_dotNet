using System.Collections.Generic;
using CommandsApi.Models;

namespace CommandsApi.Data
{
    public interface ICommandsRepo  
    {
        IEnumerable<Commands> GetAllCommands();
        Commands GetCommandById(int id);
    }
}
