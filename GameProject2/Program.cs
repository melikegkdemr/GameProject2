using GameProject2.Business.Concrete;
using GameProject2.Business.Entities;
using System;

namespace GameProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager();
            Gamer gamer = new Gamer();
            gamer.FirstName = "Melike";
            gamer.LastName = "Gökdemir";
            gamer.NationalityId = "12345678910";
            gamer.DateOfBirth = "2001";

            Gamer gamer2 = new Gamer();
            gamer2.FirstName = "Betül";
            gamer2.LastName = "Çelik";
            gamer2.NationalityId = "01987654321";
            gamer2.DateOfBirth = "2001";

            gamerManager.SignUp(gamer);
            gamerManager.Delete(gamer2);

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign();
            campaign.CampainId = 1;
            campaign.CampainName = "Sevgi ayı indirimi";
            campaign.DiscountRate = 0.25M;
            campaignManager.Add(campaign);

            GameManager gameManager = new GameManager();
            Game game = new Game();
            game.GameId = 2;
            game.GameName = "Sam2";
            game.GamePrice = 200;
            gameManager.Add(game);

            Game game2 = new Game();
            game2.GameId = 3;
            game2.GameName = "Among us";
            game2.GamePrice = 300;
            

            SaleManager saleManager = new SaleManager();
            saleManager.SalePrice(game, gamer, campaign);
            saleManager.SaleDiscount(game2,gamer2,campaign);

            
        }
    }
}
