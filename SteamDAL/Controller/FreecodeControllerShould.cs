﻿using GameStore.DTOs;
using GameStore.Extention;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace SteamMini
{
    public  class FreecodeControllerShould : Controller
    {

        public void TestGetAllFreeCodesController()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync("api/freecodes").Result;
                var content = result.Content.ReadAsStringAsync().Result;
                Responses<FreeCodeDTOs> freeCodeResponse = JsonConvert.DeserializeObject<Responses<FreeCodeDTOs>>(content);
            }

        }

        public void TestGetFreeCodeByIdGameController(string gameId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync($"api/freecodes/{gameId}").Result;
                var content = result.Content.ReadAsStringAsync().Result;
                Responses<FreeCodeDTOs> freeCodeResponse = JsonConvert.DeserializeObject<Responses<FreeCodeDTOs>>(content);
            }
        }

        public void TestPostNewFreeCodeController(string id)
        {

            SavedFreeCodeDTOs savedFreeCodeDTOsDemo = new SavedFreeCodeDTOs()
            {
                Code = (Guid.NewGuid()).ToString(),
                GameId = id.ToGuid()
            };
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.PostAsJsonAsync($"api/freecodes", savedFreeCodeDTOsDemo).Result;
                var content = result.Content.ReadAsStringAsync().Result;
                Response<string> freeCodeResponse = JsonConvert.DeserializeObject<Response<string>>(content);
            }
        }

      
    }
}
