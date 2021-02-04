using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game() { 
                Id = 1,
                Name = "Counter-Strike: Global Offensive",
                Price = 70 
            };
            Game game2 = new Game() { 
                Id = 2,
                Name = "Among Us",
                Price = 57 
            };
            Game game3 = new Game() { 
                Id = 3,
                Name = "DOTA 2",
                Price = 45 
            };
            Gamer gamer1 = new Gamer() { 
                Id = 70,
                BirthYear = 1996, FirstName = "Ali",
                LastName = "Kaya",
                IdentityNumber = 25
            };
            Gamer gamer2 = new Gamer() { 
                Id = 77,
                BirthYear = 1999,
                FirstName = "Sümeyra",
                LastName = "Sağır",
                IdentityNumber = 256
            };

            Gamer gamer3 = new Gamer() { 
                Id = 97,
                BirthYear = 2005, 
                FirstName = "Zeynep Güher", 
                LastName = "Sağır", 
                IdentityNumber = 7530
            };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { 
                Id = 69,
                BirthYear = 2000,
                FirstName = "Reha",
                LastName = "Ermetin",
                IdentityNumber = 31 });

            Campaign campaign1 = new Campaign()
            {
                GameId = 1,
                CampaignName = "Bahar İndirimleri",
                RateofDiscount = 31
            };
            Campaign campaign2 = new Campaign()
            {
                GameId = 2,
                CampaignName = "Yılbaşı İndirimleri",
                RateofDiscount = 69
            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            Sales sale1 = new Sales()
            {
                Game="Medium",Gamer="Reha",CreditCardNumber="313169"
            };

            Sales sales1 = new Sales() { Game = game1.Name, Gamer = gamer3.FirstName };
            SalesManager salesmanager = new SalesManager();
            salesmanager.Buy(game2, gamer1);
            salesmanager.Buy(game1, gamer2);
            salesmanager.Buy(game3, gamer3);

            gamerManager.Add(gamer1);
            gamerManager.Delete(gamer3);
            gamerManager.Update(gamer2);
        }
    }
}
