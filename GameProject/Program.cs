using GameProject.Abstract;
using GameProject.Concate;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer { Id = 1, FirstName = "Ayşe", LastName = "Akdoğan", DateOfBirth = new DateTime(1994, 7, 25), NationalityId = "12345678910", Password = "123456", UserName = "akdoganayse" };
            Campagn campagn1 = new Campagn { Id = 1, CampaignName = "Dev indirim" };
            IGamerService gamerService = new GamerManager(new GamerCheckManager());
            gamerService.Add(gamer1);
            ICampagnService campagnService = new CampagnManager();
            campagnService.Add(campagn1);
            IGameSellerService gameSellerService = new SellGameManager();
            gameSellerService.SellingGames(gamer1);
            gameSellerService.SellingGamesWithCampaign(gamer1, campagn1);
            
        }
    }
}
