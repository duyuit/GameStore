using GameStore.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamMini
{
    public class Responses<T> : BaseResponse
    {
        public List<T> Payload { get; set; }
    }
    public class Response<T> : BaseResponse
    {
        public T Payload { get; set; }
    }
}
