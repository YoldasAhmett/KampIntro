using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == "1999" && gamer.FirstName == "Ahmet" &&
                gamer.LastName == "Yoldaş" && gamer.IdentityNumber == 0123456)
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
