using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SteamDAL.DAO
{
  public  class BaseController
    {

        public static string BASE_URL = "http://gamestorecrosplatform.azurewebsites.net/api/";
        public static string ExecutePostRequest(string methodRequest, object param)
        {
            return ExecuteRequest(string.Empty, methodRequest, param, "post");
        }

        public static string ExecuteGetRequest(string baseUrl, string methodRequest)
        {
            return ExecuteRequest(baseUrl, methodRequest, null, "get");
        }

        public static string ExecutePutRequest(string methodRequest, object param)
        {
            return ExecuteRequest(string.Empty, methodRequest, param, "put");
        }

        public static string ExecuteRequest(string baseUrl, string methodRequest, object param, string request)
        {
            //if (true == false)
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BASE_URL + baseUrl);

                // Add header for request
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Check cookie
              

                Task<HttpResponseMessage> reponse;
                switch (request)
                {
                    case "post":
                        reponse = client.PostAsJsonAsync(methodRequest, param);
                        break;
                    case "get":
                        reponse = client.GetAsync(methodRequest);
                        break;
                    case "put":
                        reponse = client.PutAsJsonAsync(methodRequest, param);
                        break;
                    default:
                        reponse = client.GetAsync(methodRequest);
                        break;
                }

                reponse.Wait();

                // Check response message
                var result = reponse.Result;
                if (result.IsSuccessStatusCode)
                {
                    var jsonContent = result.Content.ReadAsStringAsync().Result;

                    // Check expired token
                    try
                    {
                        //var responseModel = JsonConvert.DeserializeObject<ResponseObjModel>(jsonContent);
                        //if (responseModel.Code == Constant.ExpiredCode)
                        //{
                        //    ClearCookie();
                        //    RedirectToRoute(new { controller = "Login", action = "Index" });
                        //}
                    }
                    catch (Exception ex)
                    {
                    }

                    return jsonContent;
                }
                else
                {
                    return result.StatusCode.ToString();
                }
            }
        }
    }
}
