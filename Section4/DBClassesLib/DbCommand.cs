using System;
using System.Collections.Generic;
using System.Text;

namespace DBClassesLib
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _command;

        public DbCommand(DbConnection dbConnection, string command)
        {
            _dbConnection = dbConnection is null 
                ? throw new ArgumentNullException(nameof(dbConnection))
                : dbConnection;

            _command = string.IsNullOrWhiteSpace(command)
                ? throw new ArgumentException(nameof(command))
                : command;
        }

        public void Execute()
        {
            _dbConnection.Open();

            Console.WriteLine($"Executed {_command}.");

            _dbConnection.Close();
        }

    }
}
