using System;
using System.Collections.Generic;
using System.Text;

namespace DBClassesLib
{
    public abstract class DbConnection
    {

        protected string ConnectionString { get; }
        protected TimeSpan Timeout { get; }

        public DbConnection(string connectionString, TimeSpan timeout)
        {
            ConnectionString = string.IsNullOrWhiteSpace(connectionString)
                ? throw new ArgumentException($"{nameof(connectionString)} was either null or was White Space", nameof(connectionString))
                : connectionString.Trim();
            Timeout = timeout;
        }

        public abstract void Open();

        public abstract void Close();
    }
}
