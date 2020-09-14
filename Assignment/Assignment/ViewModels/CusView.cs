using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Models;
namespace Assignment.ViewModels
{
    class CusView
    {
        public static List<Customer> cusList = new List<Customer>();

        public List<Customer> customers
        {
            get {return cusList;}
        }
        public CusView()
        {
            if (cusList.Count==0)
            {
                cusList.Add(new Customer("new customer", "new customer",1,DateTime.Now));
            }
        }
    }
}
