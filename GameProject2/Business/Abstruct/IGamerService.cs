using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Business.Abstruct
{
    interface IGamerService
    {
        void SignUp(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);

    }
}
