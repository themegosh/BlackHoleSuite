using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace BlackHoleLib
{
    public static class Database
    {
        private static string SOURCE_NAME = "BWMDB.sdb";

        public static SQLiteConnection OpenDB()
        {
            string connectString = "Data Source=" + BlackHoleSuite.APP_DIR + "\\" + SOURCE_NAME + ";"; // FailIfMissing=True
            var conn = new SQLiteConnection(connectString);

            conn.Open();

            return conn;
        }
    }
}
