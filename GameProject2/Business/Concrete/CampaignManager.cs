using GameProject2.Business.Abstruct;
using GameProject2.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Business.Concrete
{
    class CampaignManager : ICampaignService

    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampainName + " isimli kampanya eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampainName + " isimli kampanya silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampainName + " isimli kampanya güncellendi.");
        }
    }
}
