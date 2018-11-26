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
    public class AuthsControllerShould : Controller
    {
        public static string LoginController(object loginObject)
        {
            using (HttpClient client = new HttpClient())
            {
                Uri baseAddress = new Uri("http://localhost:49911/");
                client.BaseAddress = baseAddress;

                var rs = "";
                try
                {
                    HttpResponseMessage result = client.PostAsJsonAsync("api/auths", loginObject).Result;
                    var content = result.Content.ReadAsStringAsync().Result;

                    //Response<string> loginResponse = JsonConvert.DeserializeObject<Response<string>>(content);
                    var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(content);

                    if (loginResponse.IsSuccess.Equals("True"))
                    {
                        return rs = loginResponse.Payload.Id;
                    }
                    else 
                    {
                        if (loginResponse.Message.Equals("Password Incorrect"))
                        {
                            return rs = "pass";
                        }
                        else
                        {
                            return rs = "user";
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw;
                }
            }
        }

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
