using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.models
{
    class fooddata
    {
        public string message { get; set; }
        public List<food> data { get; set; }

        //public static implicit operator fooddata(CatModel v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
