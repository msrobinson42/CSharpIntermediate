using System;
using System.Collections.Generic;
using System.Text;

namespace DBClassesLib
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan timeSpan)
            : base(connectionString, timeSpan)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Oracle Connection has been closed.");
        }

        public override void Open()
        {
            Console.WriteLine("Oracle Connection has been opened.");
        }
    }
}
