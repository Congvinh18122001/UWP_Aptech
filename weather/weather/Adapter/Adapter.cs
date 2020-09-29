using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather.Adapter
{
    class Adapter
    {
        private string baseURL = "http://api.openweathermap.org/data/2.5/weather?q=hanoi,vn&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
        public string strURL
        {
            get { return string.Format(baseURL); }
        }
    }
}
