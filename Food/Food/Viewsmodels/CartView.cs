using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.models;
namespace Food.Viewsmodels
{
    class CartView
    {
        public static List<CartItem> cart= new List<CartItem>();
        public CartView()
        {
            if (cart.Count ==0)
            {
                cart.Add(new CartItem("product", "product", 0,0));
            }
        }
        public  List<CartItem> cartItems
        {
            get { return cart; }
            set { cart = value; }
        }
    }
}
