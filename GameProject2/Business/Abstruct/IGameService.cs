using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Business.Abstruct
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
