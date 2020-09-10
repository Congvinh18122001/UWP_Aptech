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
        public string icon{get;set;}
        public string Name
        {
            get { return name; }
            set { name = value; }
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

        public Assignment2(string icon, string name, string telephone, string typeContact)
        {
            this.icon = icon;
            Name = name;
            Telephone = telephone;
            TypeContact = typeContact;
        }
    }
}
