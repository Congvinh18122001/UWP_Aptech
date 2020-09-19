using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Adapters
{
    class Adapter
    {
        private string baseURL = "https://foodgroup.herokuapp.com";
        public string strURL
        {
            get {return string.Format(baseURL + "/api/today-special"); }
        }
        public string categoryDetailURL(int id)
        {
             return string.Format(baseURL + "/api/category/" + id); 
        }
        public string foodDetailURL(int id)
        {
            return string.Format(baseURL + "/api/food/" + id);
        }
    }
}
