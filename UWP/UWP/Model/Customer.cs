using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model
{
    class Customer
    {
        private string fullname;
        private string telephone;
        private int age;
        private DateTime birtday;

        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }

        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }

        }
        public int Age
        {
            get { return age; }
            set { age = value; }

        }
        public DateTime Birtday
        {
            get { return birtday; }
            set { birtday = value; }

        }

        public Customer(string fullname, string telephone, int age, DateTime birtday)
        {
            Fullname = fullname;
            Telephone = telephone;
            Age = age;
            Birtday = birtday;
        }
        public string toString()
        {
            return fullname + " | " +  telephone +" | "+ age + " | "+ birtday;
        }
    }
}
