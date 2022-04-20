using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    internal class Players
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

    }

    internal class PlayerTools
    {
        List<Players> playersList;

        
        void AddPlayers()
        {
            Players player1 = new Players() { FirstName = "Peter" };
            player1.MiddleName = "Mr. Eleven";
            player1.LastName = "TopGun";
            playersList.Add(player1);

            foreach (var player in playersList)
            {
                Console.WriteLine($"{player.FirstName} {player.LastName}");
            }
        }

    }
}
