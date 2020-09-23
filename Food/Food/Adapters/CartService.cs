using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.models;
namespace Food.Adapters
{
     interface  CartService
    {
        bool addItemToCart(food food, string amount);
        bool updateAmount(int id, int amount);
        bool deleteCartItem(int id);
        List<CartItem> getCartItems();
        bool clearCart();
    }
}
