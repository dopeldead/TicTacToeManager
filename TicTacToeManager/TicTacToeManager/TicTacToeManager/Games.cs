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
        public int Player1Id { get; set; }
        [JsonProperty( "P2" )]
        public int Player2Id { get; set; }
        [JsonProperty( "Winner" )]
        public int Winner { get; set; }
    }
}
