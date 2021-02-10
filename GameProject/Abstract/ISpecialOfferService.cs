using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISpecialOfferService
    {
        void Add(SpecialOffer specialOffer);
        void Delete(SpecialOffer specialOffer);
        void Update(SpecialOffer specialOffer);
    }
}
