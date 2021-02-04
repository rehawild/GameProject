using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesService
    {
        public void Buy(Game game, Gamer gamer)
        {
            Console.WriteLine(game.Name + " oyunu " + gamer.FirstName + " " +
                gamer.LastName + " hesabınıza yüklenmiştir.");
        }
    }
}
