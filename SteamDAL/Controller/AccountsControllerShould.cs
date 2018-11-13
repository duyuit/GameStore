using GameStore.Common;
using GameStore.DTOs;
using GameStore.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace SteamMini
{
    public class AccountsControllerShould : Controller
    {

        public void TestGetAllUsersController()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync("api/accounts").Result;
                var content = result.Content.ReadAsStringAsync().Result;
                Responses<UserDTOs> freeCodeResponse = JsonConvert.DeserializeObject<Responses<UserDTOs>>(content);
            }

        }

        public void TestGetUserByIdController(string Id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync($"api/accounts/{Id}").Result;
                var content = result.Content.ReadAsStringAsync().Result;
                Response<UserDTOs> freeCodeResponse = JsonConvert.DeserializeObject<Response<UserDTOs>>(content);
            }

        }
    }
}
