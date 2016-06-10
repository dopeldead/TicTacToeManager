using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TicTacToeManager
{
   public class User
    {
        [JsonProperty( "Id" )]
        public int Id { get; set; }
        [JsonProperty( "Username" )]
        public string UserName { get; set; }
        [JsonProperty( "AvatarId" )]
        public int AvatarId { get; set; }
        [JsonProperty( "Age" )]
        public int Age { get; set; }
    }
}
