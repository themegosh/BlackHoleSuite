using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace BlackHoleLib
{
    public static class bandwidthDB
    {
        private static string DB_NAME = "BWMDB.sdb";
        private static readonly string APP_DIR = System.Reflection.Assembly.GetExecutingAssembly().Location.Remove(System.Reflection.Assembly.GetExecutingAssembly().Location.LastIndexOf('\\') + 1);

        public static SQLiteConnection OpenDB()
        {
            string connectString = "Data Source=" + APP_DIR + DB_NAME + ";"; // FailIfMissing=True
            var conn = new SQLiteConnection(connectString);

            conn.Open();

            return conn;
        }
    }
}
