using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.models;
namespace Food.Viewsmodels
{
    class foodItem
    {
        public static food foodData = new food();
        public food food
        {
            get { return foodData; }
            set { foodData = value; }
        }
    }
}
