using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISaleService
    {
        void Sale(Gamer gamer, Game game);
        void DiscountedSale(Gamer gamer, Game game, SpecialOffer specialOffer);
    }
}
