using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Models;
namespace Assignment.ViewModels
{
    class MailView
    {
        public static List<Mail> mailList = new List<Mail>();

        public List<Mail> Mails
        {
            get { return mailList; }
        }
        public MailView()
        {
            if (mailList.Count==0)
            {
                mailList.Add(new Mail("email@gmail.com",
                "new mail", "new mail"));
            }
        }
    }
}
