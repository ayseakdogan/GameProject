using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IGameSellerService
    {
        void SellingGames(Gamer gamer);
        void SellingGamesWithCampaign(Gamer gamer, Campagn campaign);
    }
}
