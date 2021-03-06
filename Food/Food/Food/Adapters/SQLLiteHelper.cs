﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
namespace Food.Adapters
{
    class SQLLiteHelper
    {
        private readonly string DB_Name = "food2.db";
        private static SQLLiteHelper _sQLiteHelper;

        public static SQLLiteHelper createInstance()
        {
            if (_sQLiteHelper == null)
            {
                _sQLiteHelper = new SQLLiteHelper();
            }
            return _sQLiteHelper;
        }

        private SQLLiteHelper()
        {
            sQLiteConnection = new SQLiteConnection(DB_Name);
            CreateProductTable();
            CreateCartTable();
        }

        public SQLiteConnection sQLiteConnection
        {
            get;
            private set;
        }

        private void CreateProductTable()
        {
            var sql = @"CREATE TABLE IF NOT EXISTS Products(id integer primary key, name varchar(200), image varchar(200), description varchar(200), price integer)";
            var statement = sQLiteConnection.Prepare(sql);
            statement.Step();
        }
        private void CreateCartTable()
        {
            var sql = @"CREATE TABLE IF NOT EXISTS Cart(id integer primary key AUTOINCREMENT, name varchar(200), image varchar(200), amount integer, price integer,food_id)";
            var statement = sQLiteConnection.Prepare(sql);
            statement.Step();
        }
    }
}
