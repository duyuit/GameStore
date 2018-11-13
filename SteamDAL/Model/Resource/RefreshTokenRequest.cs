using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Model.Resource
{
    public class RefreshTokenRequest
    {
        public string Email { get; set; }
        public string RefreshToken { get; set; }
    }
}
