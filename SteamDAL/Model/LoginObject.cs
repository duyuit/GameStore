using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamMini.Class
{
    class LoginObject
    {
        public LoginObject(string mail,string pass )
        {
            Email = mail;
            Password = pass;
        }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
