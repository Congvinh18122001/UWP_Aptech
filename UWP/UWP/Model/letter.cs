using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WPF.Model
{
    class letter
    {
        private string email;
        private string title;
        private string content;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public letter(string email, string title, string content)
        {
            Email = email;
            Title = title;
            Content = content;
        }
        public string toString()
        {
            if (content.Length > 40)
            {
                string Str1 = content.Substring(0, 40);
                return "Send to " + email + "\n" + "Title : " + title + "\n" + Str1 + "...";
            }
            else
            {
        
                return "-------------------------- \n"+"Send to " + email + "\n" + "Title : " + title + "\n" + content ;
            }
            
        }
    }
}
