using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRACTICAL.Models;
namespace PRACTICAL.Adapter
{
    interface UserService
    {
        bool addAccc(string acc, string pass);
        List<User> getUsers();
    }
}
