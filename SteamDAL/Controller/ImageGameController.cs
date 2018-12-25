using GameStore.Common;
using GameStore.DTOs;
using GameStore.Model;
using Newtonsoft.Json;
using SteamMini.Class;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;


namespace SteamMini
{
    public class ImageGameController: Controller
    {
        public string PostImage(object imageObject)
        {
            using (HttpClient client = new HttpClient())
            {
                Uri baseAddress = new Uri("http://localhost:49911/");
                client.BaseAddress = baseAddress;

                HttpResponseMessage result = client.PostAsJsonAsync("api/Images/game", imageObject).Result;

                var content = result.Content.ReadAsStringAsync().Result;
                Response<string> response = JsonConvert.DeserializeObject<Response<string>>(content);
                var rs = response.IsSuccess.ToString();

                return rs;
            }
        }
    }
}
