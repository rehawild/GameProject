using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.FirstName == "Reha"
                && gamer.LastName=="Ermetin" && gamer.IdentityNumber == 31)
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
