using GameProject2.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Business.Abstruct
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);

    }
}
