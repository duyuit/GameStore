using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamMini.Class
{
    class RegisterObject
    {
        public RegisterObject(string mail,string pass)
        {
            Email = mail;
            PassWord = ConfirmPassWord = pass;
        }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string ConfirmPassWord { get; set; }
    }
}
