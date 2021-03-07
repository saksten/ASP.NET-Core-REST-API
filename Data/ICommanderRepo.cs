using System.Collections.Generic;
using WebApi_Application.Models;

namespace WebApi_Application.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        bool SaveChanges();
    }
}