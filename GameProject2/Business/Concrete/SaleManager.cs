using GameProject2.Business.Abstruct;
using GameProject2.Business.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Business.Concrete
{
    class SaleManager : ISaleService

    {
        public void SaleDiscount(Game game,Gamer gamer,Campaign campaign)
        {
            Console.WriteLine(game.GameName + "isimli oyun "+ gamer.FirstName + " adlı kişiye" + campaign.DiscountRate*game.GamePrice + " fiyatı ile satıldı.");
        }

        public void SalePrice(Game game,Gamer gamer,Campaign campaign)
        {
            Console.WriteLine(game.GameName + " isimli oyun " + gamer.FirstName + " adlı kişiye" + game.GamePrice + " fiyatı ile satıldı.");
        }
    }
}
