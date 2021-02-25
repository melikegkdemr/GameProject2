using GameProject2.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Business.Abstruct
{
    interface ISaleService
    {
        void SalePrice(Game game, Gamer gamer, Campaign campaign);
        void SaleDiscount(Game game, Gamer gamer, Campaign campaign);
    }
}
