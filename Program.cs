using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerTesting
{
    class Program
    {
        public static List<Player> playerList()
        {
            List<Player> listPlayers = new List<Player>
            {
                new Player{PlayerId=1,PlayerName="Ronaldo",PlayerTeam="Portugal"},
                new Player{PlayerId=2,PlayerName="Mbappe",PlayerTeam="France"},
                new Player{PlayerId=3,PlayerName="Messi",PlayerTeam="Argentina"},
            };
            return listPlayers;
        }

        static void Main(string[] args)
        {

        }
    }
}
