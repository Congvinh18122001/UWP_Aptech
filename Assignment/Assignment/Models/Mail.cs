using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    class Mail
    {
        private string email;
        private string subject;
        private string description;


        public Mail(string email, string subject, string content)
        {
            Email = email;
            Subject = subject;
            Description = content;
        }

        public string Email
        {
            get { return email; }
            set { email = value;}
        }

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
