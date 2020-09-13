using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    class Customer
    {
        private string fullName;
        private string telePhone;
        private int age;
        private DateTime birthday;

        public Customer(string fullName, string telePhone, int age, DateTime birthday)
        {
            FullName = fullName;
            TelePhone = telePhone;
            Age = age;
            Birthday = birthday;
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string TelePhone
        {
            get { return telePhone; }
            set { telePhone = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public string ToString()
        {
            return FullName + "--" + TelePhone +
                "--" + Age + "--" + Birthday.ToString() + "\n";
        }
    }
}
