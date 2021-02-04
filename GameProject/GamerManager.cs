using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this._userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
            {
            if (_userValidationService.Validate(gamer) == true)
                {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " hesabının kaydı gerçekleşmiştir");

                }
            else
            {
                Console.WriteLine("Doğrulama başarısız kayıt başarısız");
            }
            }
        public void Delete(Gamer gamer)
            {
                Console.WriteLine(gamer.FirstName + " " +  gamer.LastName + " hesabının Kaydı Güncellendi");
            }

         public void Update(Gamer gamer)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " hesabının Kaydı Silindi");
            }
    }
}
