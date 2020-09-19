using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.models
{
    class CartItem
    {
        public string name { get; set; }
        public string image { get; set; }
        public int price { get; set; }
        public int amount { get; set; }
        public string Price
        {
            get
            {
                var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                return String.Format(info, "{0:c}", price);
            }
        }
        public CartItem(string name, string image, int price, int amount)
        {
            this.name = name;
            this.image = image;
            this.price = price;
            this.amount = amount;
        }
    }
}
