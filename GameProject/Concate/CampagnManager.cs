using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concate
{
    public class CampagnManager : ICampagnService
    {
        public void Add(Campagn campaign)
        {
            Console.WriteLine(campaign.CampaignName+" kampanya eklendi");
        }

        public void Delete(Campagn campaign)
        {
            Console.WriteLine(campaign.CampaignName+" kampanya silindi" );
        }

        public void Update(Campagn campaign)
        {
            Console.WriteLine(campaign.CampaignName+" kampanya güncellendi");
        }
    }
}
