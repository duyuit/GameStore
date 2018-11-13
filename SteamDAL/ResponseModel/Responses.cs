using GameStore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamMini
{
    class Responses<T> : BaseResponse
    {
        public List<T> Payload { get; set; }
    }
    class Response<T> : BaseResponse
    {
        public T Payload { get; set; }
    }
}
