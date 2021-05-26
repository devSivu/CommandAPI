using System.Collections.Generic;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="How to generate a migration", CommandLine="dotnet", Platform=".Net"},
                new Command{Id=1, HowTo="Run Migrations,", CommandLine="dotnet", Platform=".Net"},
                new Command{Id=2, HowTo="List Activation,", CommandLine="dotnet", Platform=".Net"}
            };

            return commands;

        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="How to generate a migration", CommandLine="dotnet", Platform=".Net"};

        }

        public bool saveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}