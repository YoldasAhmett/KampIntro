using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        //Kullanıcının eklediği oyunları bir listede tutmak istedim.
        private List<Game> games = new List<Game>();
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " oyunu eklendi. " + "Fiyatı: " + game.Price);
            games.Add(game);//Her bir oyun eklendiğinde listeme eklenicek.

            //Kalan oyunları kullanıcıya göstermek istedim.
            Console.WriteLine("Katalogdaki tüm oyunlar: ");
            foreach (Game oneGame in games)
            {
                Console.WriteLine("Oyun Id: " + oneGame.Id + " Oyun Adı: " + oneGame.Name +
                    " Oyun fiyatı: " + oneGame.Price);
            }

            Console.WriteLine();
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " oyunu kaldırıldı. ");
            games.Remove(game);//Her bir oyun silindiğinde listemden de silinecek.

            //Kalan oyunları kullanıcıya göstermek istedim.
            Console.WriteLine("Katalogdaki tüm oyunlar: ");
            foreach (Game oneGame in games)
            {
                Console.WriteLine("Oyun Id: " + oneGame.Id + " Oyun Adı: " + oneGame.Name +
                    " Oyun fiyatı: " + oneGame.Price);
            }

            Console.WriteLine();
        }
    }
}
