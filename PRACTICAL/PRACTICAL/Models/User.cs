using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAL.Models
{
    class User
    {
       public string account { get; set; }
        public string password { get; set; }

        public User(string account, string password)
        {
            this.account = account;
            this.password = password;
        }
    }
}
