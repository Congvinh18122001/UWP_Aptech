using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.models
{
    class CatModel
    {
        public string message { get; set; }
        public Data data { get; set; }

        public static implicit operator CatModel(fooddata v)
        {
            throw new NotImplementedException();
        }
    }
    class Data
    {
        public MenuItem category { get; set; }
        public List<food> foods { get; set; }
    }
}
