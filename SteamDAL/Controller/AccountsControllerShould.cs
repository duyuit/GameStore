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
        public static string PostNewAccountController(object accountObject)
        {
            using (HttpClient client = new HttpClient())
            {
                Uri baseAddress = new Uri("http://localhost:49911/");
                client.BaseAddress = baseAddress;

                HttpResponseMessage result = client.PostAsJsonAsync("api/accounts", accountObject).Result;

                var content = result.Content.ReadAsStringAsync().Result;
                Response<string> response = JsonConvert.DeserializeObject<Response<string>>(content);
                var rs = response.IsSuccess.ToString();
                return rs;
            }
        }

        //public static string LoginController(object loginObject)
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        Uri baseAddress = new Uri("http://localhost:49911/");
        //        client.BaseAddress = baseAddress;

        //        HttpResponseMessage result = client.PostAsJsonAsync("api/auths", loginObject).Result;
        //        //var content = result.Content.ReadAsStringAsync().Result;
        //        //Response<string> loginResponse = JsonConvert.DeserializeObject<Response<string>>(content);

        //        var content = "";
        //        if (result.ReasonPhrase.Equals("Bad Request") || result.ReasonPhrase.Equals("Unauthorized"))
        //        {
        //            content = result.ReasonPhrase;
        //        }
        //        else //result.ReasonPhrase.Equals("OK"), get token
        //        {
        //            content = result.ReasonPhrase;
        //        }

        //        return content;
        //    }
        //}



        public void TestGetAllUsersController()
        {
            using (HttpClient client = new HttpClient())
            {
                Uri baseAddress = new Uri("http://localhost:49911/");
                client.BaseAddress = baseAddress;

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
