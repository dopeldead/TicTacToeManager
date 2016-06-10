using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TicTacToeManager
{
    class JsonRootObject
    {
        [JsonProperty( "Users" )]
        public List<User> UserList { get; set; }
        [JsonProperty( "Games" )]
        public List<Game> GameList { get; set; }
    }
}
