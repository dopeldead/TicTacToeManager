using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TicTacToeManager
{
   public class Game
    {

        [JsonProperty( "GameId" )]
        public int Id { get; set; }
        [JsonProperty( "P1" )]
        public User Player1 { get; set; }
        [JsonProperty( "P2" )]
        public User Player2 { get; set; }
        [JsonProperty( "Winner" )]
        public User Winner { get; set; }
    }
}
