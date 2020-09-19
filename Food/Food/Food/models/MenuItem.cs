using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.models
{
    class MenuItem
    {
        public int id { get; set; }
        public string icon { get; set; }
        public string name { get; set; }

        public MenuItem(int id, string icon, string name)
        {
            this.id = id;
            this.icon = icon;
            this.name = name;
        }
    }
}
