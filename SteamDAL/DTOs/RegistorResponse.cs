using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamMini.Class
{
    public class RegistorResponse
    {
        public string IsSuccess { set; get; }
        public string Message { set; get; }
        //public PayloadReg Payload { get; set; }
        public virtual ICollection<PayloadReg> Payload { get; set; }
    }
    public class PayloadReg
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
