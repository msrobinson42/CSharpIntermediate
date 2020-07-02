using System;
using System.Collections.Generic;
using System.Text;

namespace DBClassesLib
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        private readonly TimeSpan _timeOut;

        public DbConnection(string connectionString, TimeSpan timeout)
        {
            _connectionString = string.IsNullOrWhiteSpace(connectionString)
                ? throw new ArgumentException($"{nameof(connectionString)} was either null or was White Space", nameof(connectionString))
                : connectionString.Trim();
            _timeOut = timeout;
        }

        public abstract void Open();

        public abstract void Close();
    }
}
