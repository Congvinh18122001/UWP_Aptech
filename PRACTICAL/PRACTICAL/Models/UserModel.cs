using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRACTICAL.Adapter;
using PRACTICAL.Services;
using SQLitePCL;
using PRACTICAL.Models;
namespace PRACTICAL.Models
{
    class UserModel : UserService
    {
        public bool addAccc(string acc, string pass)
        {
            DBHelper sQLiteHelper = DBHelper.createInstance();

            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var sqlString = "INSERT INTO Users(account,password) VALUES(?,?)";
            var stt = sQLiteConnection.Prepare(sqlString);
            stt.Bind(1, acc);
            stt.Bind(2, pass);
           
            var result = stt.Step();
            return result == SQLiteResult.OK;
        }
        private List<User> users = new List<User>();
        public List<User> getUsers()
        {
            users.Clear();
            DBHelper sQLiteHelper = DBHelper.createInstance();
            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var sqlString = "SELECT * FROM Users";
            var stt = sQLiteConnection.Prepare(sqlString);
            while (SQLiteResult.ROW == stt.Step())
            {
                var acc = (string)stt[0];
                var pass = (string)stt[1];
                users.Add(new User(acc, pass));
            }
            return users;
        }
    }
}
