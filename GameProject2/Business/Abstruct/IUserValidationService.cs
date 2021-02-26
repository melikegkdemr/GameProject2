using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2.Business.Abstruct
{
    interface IUserValidationService
    {
        bool Validation(Gamer gamer);
    }
}
