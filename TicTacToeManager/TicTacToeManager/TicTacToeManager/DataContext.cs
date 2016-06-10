using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TicTacToeManager
{
    public static class DataContext
    {
        public static bool Init()
        {

            try
            {

                Uri url = new Uri("https://api.myjson.com/bins/4rvko");
                
                string checkResult = null;

                using( var httpClient = new HttpClient() )
                {
                    var result = httpClient.GetStringAsync(url);
                    checkResult = result.ToString();                                    
                }

                JsonRootObject  JsonObject = JsonConvert.DeserializeObject<JsonRootObject>(checkResult);
                Users = JsonObject.UserList;
                Games = JsonObject.GameList;
                return true;
            }
            catch(Exception)
            {
                return false;
                //no network, no json, error....
            }
        }

        public static string Json
        {
            get;private set;
        }
        public static IReadOnlyList<User> Users { get; private set; }
        public static IReadOnlyList<Game> Games { get; private set; }

    }
}
