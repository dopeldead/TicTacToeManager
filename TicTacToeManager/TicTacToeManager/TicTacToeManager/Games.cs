using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeManager
{
   public class Game
    {
        public int Id { get; set; }
        public User Player1 { get; set; }
        public User Player2 { get; set; }
        public User Winner { get; set; }
    }
}
