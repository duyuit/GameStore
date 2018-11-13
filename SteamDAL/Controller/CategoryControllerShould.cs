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
    public class CategoryControllerShould : Controller
    {
        public void TestGetAllCategoriesController()
        {
            Init(49913);
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync("api/categories").Result;
                var content = result.Content.ReadAsStringAsync().Result;
                Responses<CategoryDTOs> categoriesResponse = JsonConvert.DeserializeObject<Responses<CategoryDTOs>>(content);
            }
        }

        


    }
}
