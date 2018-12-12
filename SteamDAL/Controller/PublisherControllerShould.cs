using GameStore.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;

namespace SteamMini
{
    public class PublisherEventArgs:EventArgs
    {
        public Responses<PublisherDTOs> respone { get; set; }
        public PublisherEventArgs(Responses<PublisherDTOs> a)
        {
            respone = a;
        }
    }
  public  class PublisherControllerShould : Controller
    {
        public Responses<PublisherDTOs> GetAllPublishersController(EventHandler callback = null)
        {
            using (HttpClient client = new HttpClient())
            {
                if (BASE_URI != null)
                    client.BaseAddress = BASE_URI;
                else
                {
                    client.BaseAddress = new Uri("http://localhost:49911/");
                }
                HttpResponseMessage result = client.GetAsync("api/publishers").Result;
                var content = result.Content.ReadAsStringAsync().Result;
                Responses<PublisherDTOs> publishersResponse = JsonConvert.DeserializeObject<Responses<PublisherDTOs>>(content);

                if(publishersResponse.IsSuccess)
                callback.Invoke(null, new PublisherEventArgs(publishersResponse));
                return publishersResponse;
            }
            

        }

        public static Response<PublisherDTOs> GetPublisherByIdController(string Id)
        {
            using (HttpClient client = new HttpClient())
            {
                if (BASE_URI != null)
                    client.BaseAddress = BASE_URI;
                else
                {
                    client.BaseAddress = new Uri("http://localhost:49911/");
                }
                HttpResponseMessage result = client.GetAsync($"api/publishers/{Id}").Result;
                var content = result.Content.ReadAsStringAsync().Result;
                Response<PublisherDTOs> publisherResponse = JsonConvert.DeserializeObject<Response<PublisherDTOs>>(content);
                return publisherResponse;
            }

        }

        public void PostNewPublisherController(string name, int money, int reliability)
        {
            SavedPublisherDTOs savedPublisherDTOs = new SavedPublisherDTOs()
            {
               Name= name,
               Money=money,
               Reliability=reliability
            };
            using (HttpClient client = new HttpClient())
            {
                if (BASE_URI != null)
                    client.BaseAddress = BASE_URI;
                else
                {
                    client.BaseAddress = new Uri("http://localhost:49911/");
                }
                HttpResponseMessage result = client.PostAsJsonAsync($"api/publishers", savedPublisherDTOs).Result;
                var content = result.Content.ReadAsStringAsync().Result;
                Response<PublisherDTOs> freeCodeResponse = JsonConvert.DeserializeObject<Response<PublisherDTOs>>(content);
            }
        }
    }
}
