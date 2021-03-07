using System.Collections.Generic;
using WebApi_Application.Models;

namespace WebApi_Application.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> {
                new Command{Id=0, HowTo="What to do 1 ", Line="The specific line", 
            Platform="The Platform"},
            new Command{Id=1, HowTo="What to do2", Line="The specific line", 
            Platform="The Platform"},
            new Command{Id=2, HowTo="What to do3", Line="The specific line", 
            Platform="The Platform"},
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=100, HowTo="HardCoed - What to do", Line="The specific line", 
            Platform="The Platform"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}