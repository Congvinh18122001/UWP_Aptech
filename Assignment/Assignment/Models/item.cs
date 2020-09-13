using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    class item
    {
        char icon;
        string name;
        string dest;

        public item(string dest, char icon, string name)
        {
            Dest = dest;
            Icon = icon;
            Name = name;
        }

        public string Dest
        {
            get { return dest; }
            set { dest = value; }
        }

        public char Icon
        {
            get { return icon; }
            set { icon = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
