using GameStore.DTOs;
using Newtonsoft.Json;
using GameStore.Extention;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Collections.ObjectModel;

namespace SteamMini
{
    public class GameControllerShould : Controller
    {
        public Responses<GameDTOs> GetAllGamesController()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync("api/games").Result;
                var content = result.Content.ReadAsStringAsync().Result;
                Responses<GameDTOs> gamesResponse = JsonConvert.DeserializeObject<Responses<GameDTOs>>(content);
                return gamesResponse;
            }

        }

        public Response<GameDTOs> GetGameByIdController(string Id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.GetAsync($"api/games/{Id}").Result;
                var content = result.Content.ReadAsStringAsync().Result;
                Response<GameDTOs> gamesResponse = JsonConvert.DeserializeObject<Response<GameDTOs>>(content);
                return gamesResponse;
            }

        }

        public void PostNewGameController(string name, string publisherId,
                                              string members1, string members2,
                                              string favoriteMembers1, string favoriteMembers2,
                                              float rating,string logo,
                                              string videoUrl,string content,
                                              string categories1,string categories2,
                                              float price,
                                              EventHandler callback = null)
        {
        //    Init(49914);

            SavedGameDTOs savedGameDTOs = new SavedGameDTOs()
            {
                Name = name,
                PublisherId = publisherId.ToGuid(),
                Members = new Collection<Guid>{},
                FavoriteMembers= new Collection<Guid> {},
                Rating=rating,
                Logo=logo,
                VideoUrl=videoUrl,
                Content=content,
                Categories=new Collection<Guid> {},
                Price=price,
                PurchaseDate=DateTime.Now
            };
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = BASE_URI;
                HttpResponseMessage result = client.PostAsJsonAsync($"api/games", savedGameDTOs).Result;
                var contentResult = result.Content.ReadAsStringAsync().Result;
                Response<GameDTOs> gameResponse = JsonConvert.DeserializeObject<Response<GameDTOs>>(contentResult);
                callback.Invoke(null,null);
            }

        }
    }
}
