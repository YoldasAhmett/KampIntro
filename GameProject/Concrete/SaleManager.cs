using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " kullanıcısı "
                + game.Name + " oyununu " + game.Price + " TL' ye satın aldı");
        }

        public void DiscountedSale(Gamer gamer, Game game, SpecialOffer specialOffer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " kullanıcısı, "
                + game.Name + " oyununu " + specialOffer.Name + " indirimi ile " + game.Price + " TL' ye satın aldı.");

            //Yapılması gerekenler:
            //1.Ürünün indirimli fiyatının gösterilmesi gerekir. Bunun içinde bir matematik sınıfı oluştumak
            //lazım sanırım.

        }
    }
}
