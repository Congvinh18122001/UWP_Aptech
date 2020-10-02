using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
namespace PRACTICAL.Services
{
    class DBHelper
    {
        private readonly string DB_Name = "user.db";
        private static DBHelper _sQLiteHelper;

        public static DBHelper createInstance()
        {
            if (_sQLiteHelper == null)
            {
                _sQLiteHelper = new DBHelper();
            }
            return _sQLiteHelper;
        }

        private DBHelper()
        {
            sQLiteConnection = new SQLiteConnection(DB_Name);
            CreateUserTable();
        }

        public SQLiteConnection sQLiteConnection
        {
            get;
            private set;
        }

        private void CreateUserTable()
        {
            var sql = @"CREATE TABLE IF NOT EXISTS Users(account varchar(100) primary key, password varchar(200))";
            var statement = sQLiteConnection.Prepare(sql);
            statement.Step();
        }
    }
}
