using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.models
{
    class food
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public string Price { get {
                var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                return String.Format(info, "{0:c}", price); } }
    }
}
