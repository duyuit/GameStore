using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamMini.Class
{
    class RegisterObject
    {
        public RegisterObject(string mail,string pass, string hobbies, string fullName, 
            string phoneNumber, string displayName)
        {
            Email = mail;
            PassWord = pass;
            Hobbies = hobbies; //none
            FullName = fullName; //none
            PhoneNumber = phoneNumber; //none
            UserName = displayName;
        }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public string Hobbies { get; set; } //none
        public string FullName { get; set; } //none
        public string PhoneNumber { get; set; } //none
        public string UserName { get; set; }
    }
}
