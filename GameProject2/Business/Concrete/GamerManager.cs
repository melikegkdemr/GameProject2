using GameProject2.Business.Abstruct;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    class GamerManager:IGamerService
    {
        //BİR İŞ SINIFINI BAŞKA BİR İŞ SINIFININ İÇİNDE KULLANIRKEN CONSTRUCT CLASS KULLANMAMIZ GEREKİR. ASLA NEW LENEMEZ!!

        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void SignUp(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer))
            {
                Console.WriteLine("Kayıt olundu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }
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
