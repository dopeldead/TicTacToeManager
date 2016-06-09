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
            try
            {
                //loadjson
            }catch(Exception ex)
            {
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
