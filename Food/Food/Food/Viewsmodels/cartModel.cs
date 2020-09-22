using Food.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Adapters;
using SQLitePCL;

namespace Food.Viewsmodels
{
    class cartModel
    {
        private List<CartItem> cartItems = new List<CartItem>();
        public void addItemToCart(food food , string amount)
        {
            SQLLiteHelper sQLiteHelper = SQLLiteHelper.createInstance();

            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var sqlString = "INSERT INTO Cart(name,image,amount,price,food_id) VALUES(?,?,?,?,?)";
            var stt = sQLiteConnection.Prepare(sqlString);
            stt.Bind(1, food.name);
            stt.Bind(2, food.image);
            stt.Bind(3, Int32.Parse(amount));
            stt.Bind(4, food.price);
            stt.Bind(5, food.id);
            stt.Step();
        }
        public void updateAmount(int id , int amount)
        {
            SQLLiteHelper sQLiteHelper = SQLLiteHelper.createInstance();

            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var sqlString = "update Cart set amount = ? where id = ?";
            var stt = sQLiteConnection.Prepare(sqlString);
            stt.Bind(1,amount);
            stt.Bind(2, id);
          
            stt.Step();
        }
        public void deleteCartItem(int id)
        {
            SQLLiteHelper sQLiteHelper = SQLLiteHelper.createInstance();
            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var sqlString = "DELETE FROM Cart WHERE id = ?;";
            var stt = sQLiteConnection.Prepare(sqlString);
            stt.Bind(1, id);
            stt.Step();
            
        }
        public List<CartItem> getCartItems()
        {
            cartItems.Clear();
            SQLLiteHelper sQLiteHelper = SQLLiteHelper.createInstance();
            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var sqlString = "SELECT * FROM Cart";
            var stt = sQLiteConnection.Prepare(sqlString);
            while (SQLiteResult.ROW == stt.Step())
            {
                var id = Convert.ToInt32(stt[0]);
                var name = (string)stt[1];
                var image = (string)stt[2];
                var amount = Convert.ToInt32(stt[3]);
                var price = Convert.ToInt32(stt[4]);
                var foodId = Convert.ToInt32(stt[5]);
                cartItems.Add(new CartItem(id, name, image, price, amount,foodId));
            }
            return cartItems;
        }
    }
}
