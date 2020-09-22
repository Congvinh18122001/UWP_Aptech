using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.models;
using Food.Adapters;
using SQLitePCL;

namespace Food.Viewsmodels
{
    class favoriteView
    {
        private static List<food> favoriteList = new List<food>();

        public List<food> GetFavourite()
        {
            favoriteList.Clear();
            SQLLiteHelper sQLiteHelper = SQLLiteHelper.createInstance();
            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var sqlString = "SELECT * FROM Products";
            var stt = sQLiteConnection.Prepare(sqlString);
            while (SQLiteResult.ROW == stt.Step())
            {
                var id = Convert.ToInt32(stt[0]);
                var name = (string)stt[1];
                var image = (string)stt[2];
                var description = (string)stt[3];
                var price = Convert.ToInt32(stt[4]);

                favoriteList.Add(new food(id, name, image, description, price));
            }
            return favoriteList;
            
        }
        public void addFavorite(food food )
        {
            SQLLiteHelper sQLiteHelper = SQLLiteHelper.createInstance();

            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var sqlString = "INSERT INTO Products(id,name,image,description,price) VALUES(?,?,?,?,?)";
            var stt = sQLiteConnection.Prepare(sqlString);
            stt.Bind(1, food.id);
            stt.Bind(2, food.name);
            stt.Bind(3, food.image);
            stt.Bind(4, food.description);
            stt.Bind(5, food.price);
            stt.Step();
        }
        public void deleteFavorite(int id)
        {
            SQLLiteHelper sQLiteHelper = SQLLiteHelper.createInstance();

            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var sqlString = "DELETE FROM Products WHERE id = ?";
            var stt = sQLiteConnection.Prepare(sqlString);
            stt.Bind(1, id);
            stt.Step();
        }
    }
}
