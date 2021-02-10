using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SpecialOfferManager : ISpecialOfferService
    {
        //Kullanıcı kampanya eklerse o kampanyaları bir listede tutmak istedim.
        private List<SpecialOffer> specialOffers = new List<SpecialOffer>();
        public void Add(SpecialOffer specialOffer)
        {
            Console.WriteLine("Kampanya Eklendi. Name: " + specialOffer.Name
                + "DiscountRate: " + specialOffer.DiscountRate);

            specialOffers.Add(specialOffer);//Her bir kampanya listeme eklenecek.

            //Kampanya eklendiğinde tüm kampanyaları kullanıcıya gösterdim.
            Console.WriteLine("Tüm kampanyalar ");
            foreach (SpecialOffer specialOf in specialOffers)
            {
                Console.WriteLine("Id: " +specialOf.Id + " Name: "+ specialOf.Name +
                    "Discount rate: " + specialOf.DiscountRate);
            }

            Console.WriteLine();

            //Eklenmesi gereken şeyler:
            //1.Aynı kampanya zaten varsa eklenmemeli.

        }

        public void Delete(SpecialOffer specialOffer)
        {
            Console.WriteLine("Kampanya Süresi Bitti. Name: " + specialOffer.Name);
            specialOffers.Remove(specialOffer);//Her bir kampanya listemden silinecek.

            //Kampanya silindiğinde tüm kampanyaları kullanıcıya gösterdim.
            Console.WriteLine("Tüm kampanyalar ");
            foreach (SpecialOffer specialOf in specialOffers)
            {
                Console.WriteLine("Id: " + specialOf.Id + " Name: " + specialOf.Name +
                    "Discount rate: " + specialOf.DiscountRate);
            }

            Console.WriteLine();
        }

        public void Update(SpecialOffer specialOffer)
        {
            Console.WriteLine("Kampanya Güncellendi. Name: " + specialOffer.Name);
            //Burada da güncelleme yapmak istemiştim aslında ama nasıl yapılacağını
            //öğrenemedim. Öğrendiğimde burayı da tamamlayacağım.
        }
    }
}
