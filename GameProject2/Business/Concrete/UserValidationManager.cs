using GameProject2.Business.Abstruct;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Business.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.FirstName == "MELİKE" && gamer.LastName == "GÖKDEMİR" && gamer.NationalityId == "12345678910" && gamer.DateOfBirth == "2001")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      
    }
}
