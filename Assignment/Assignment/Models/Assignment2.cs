using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    class Assignment2
    {
        private string name;
        private string telephone;
        private string typeContact;
        private char icon;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public char Icon
        {
            get { return icon; }
            set { icon = value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        public string TypeContact
        {
            get { return typeContact; }
            set { typeContact = value; }
        }

        public Assignment2(string name, char icon, string telephone, string typeContact)
        {
            Name = name;
            Icon = icon;
            Telephone = telephone;
            TypeContact = typeContact;
        }
    }
}
