using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeManager
{
    public static class DataContext
    {
        public static bool Init()
        {
            throw new NotImplementedException();
        }

        public static string Json
        {
            get;private set;
        }
        public static IReadOnlyList<User> Users { get; private set; }
        public static IReadOnlyList<Game> Games { get; private set; }

    }
}
