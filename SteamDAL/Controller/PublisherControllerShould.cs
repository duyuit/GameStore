using GameStore.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace SteamMini
{
  public  class PublisherControllerShould : Controller
    {
        public void TestGetAllPublishersController()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync("api/publishers").Result;
                var content = result.Content.ReadAsStringAsync().Result;
                Responses<PublisherDTOs> publishersResponse = JsonConvert.DeserializeObject<Responses<PublisherDTOs>>(content);
            }

        }

        public void TestGetPublisherByIdController(string Id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync($"api/publishers/{Id}").Result;
                var content = result.Content.ReadAsStringAsync().Result;
                Response<PublisherDTOs> publisherResponse = JsonConvert.DeserializeObject<Response<PublisherDTOs>>(content);
            }

        }

        public void TestPostNewPublisherController(string name,int money,int reliability)
        {
            SavedPublisherDTOs savedPublisherDTOs = new SavedPublisherDTOs()
            {
               Name= name,
               Money=money,
               Reliability=reliability
            };
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.PostAsJsonAsync($"api/publishers", savedPublisherDTOs).Result;
                var content = result.Content.ReadAsStringAsync().Result;
                Response<PublisherDTOs> freeCodeResponse = JsonConvert.DeserializeObject<Response<PublisherDTOs>>(content);
            }
        }
    }
}
