using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.models;
namespace Food.Viewsmodels
{
    class favoriteView
    {
        public static List<food> favoriteList = new List<food>();
        public List<food> foods
        {
            get { return favoriteList; }
            set { favoriteList = value; }
        }
    }
}
