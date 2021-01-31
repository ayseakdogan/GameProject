using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concate
{
    public class SellGameManager : IGameSellerService
    {
        public void SellingGames(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" oyun satın aldı");
        }

        public void SellingGamesWithCampaign(Gamer gamer, Campagn campaign)
        {
            Console.WriteLine(gamer.FirstName + " oyun satın aldı "+campaign.CampaignName);
        }
    }
}
