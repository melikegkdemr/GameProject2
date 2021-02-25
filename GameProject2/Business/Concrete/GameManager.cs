using GameProject2.Business.Abstruct;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Business.Concrete
{
    class GameManager : IGameService

    {
        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName +  " adlı oyun silindi.");
        }

        
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun eklendi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " oyun güncellendi.");
        }

    }
}
