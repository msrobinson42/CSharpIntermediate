using System;
using System.Collections.Generic;
using System.Text;

namespace DBClassesLib
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString, TimeSpan timeSpan)
            : base(connectionString, timeSpan)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Sql Connection has been closed.");
        }

        public override void Open()
        {
            Console.WriteLine("Sql Connection has been opened.");
        }
    }
}
