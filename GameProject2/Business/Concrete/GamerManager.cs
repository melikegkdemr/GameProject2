using GameProject2.Business.Abstruct;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    class GamerManager:IGamerService
    {


        public void SignUp(Gamer gamer)
        {
            Console.WriteLine("Kaydınız başarıyla gerçekleşti.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kaydınız silinmiştir.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Bilgileriniz başarıyla güncellendi.");
        }

        
    }

}
