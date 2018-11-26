using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamMini.Class
{
    public class LoginResponse
    {
        public string IsSuccess { set; get; }
        public string Message { set; get; }
        public PayloadBody Payload { get; set; }
    }
    public class PayloadBody
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public string Id { get; set; }
    }
}
