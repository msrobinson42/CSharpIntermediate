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

            _command = string.IsNullOrWhiteSpace(command)
                ? throw new ArgumentException(nameof(command))
                : command;

            _dbConnection = dbConnection ?? throw new ArgumentNullException(nameof(dbConnection));
        }

        public void Execute()
        {
            _dbConnection.Open();

            Console.WriteLine($"Executed {_command}.");

            _dbConnection.Close();
        }

    }
}
