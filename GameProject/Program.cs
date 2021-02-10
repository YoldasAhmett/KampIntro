using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationSystem());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                UserName = "sevaus100",
                FirstName = "Ahmet",
                LastName = "Yoldaş",
                BirthYear = "1999",
                IdentityNumber = 0123456,
                Password = "123",
            });
            gamerManager.Add(new Gamer
            {
                Id = 2,
                UserName = "Master",
                FirstName = "RUMEYSA ",
                LastName = "ÖZDEMİR",
                BirthYear = "1994",
                IdentityNumber = 12345,
                Password = "Kendisi belirlemiş ben bilmiyorum."
            }); ;


            Game game1 = new Game() { Id = 1, Name = "Hitman 2", Price = 79.90 };
            Game game2 = new Game() { Id = 2, Name = "Assassin's Creed 2 Brotherhood", Price = 54.90 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);

            SpecialOffer specialOffer1 = new SpecialOffer() { Id = 1, Name = "Büyük Cuma Kampanyası", DiscountRate = 15 };
            SpecialOffer specialOffer2 = new SpecialOffer() { Id = 2, Name = "Dev Teknoloji Kampanyası", DiscountRate = 20 };

            SpecialOfferManager specialOfferManager = new SpecialOfferManager();
            specialOfferManager.Add(specialOffer1);
            specialOfferManager.Add(specialOffer2);

            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                IdentityNumber = 0123456,
                FirstName = "Ahmet",
                LastName = "Yoldaş",
                BirthYear = "1999",
                UserName = "Sevaus100",
                Password = "1234"
            };

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(gamer1, game1);
            saleManager.DiscountedSale(gamer1, game2, specialOffer2);
        }
    }
}
