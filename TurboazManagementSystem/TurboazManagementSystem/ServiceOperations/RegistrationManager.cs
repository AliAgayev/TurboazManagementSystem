using System;
using System.Collections.Generic;
using System.Text;
using TurboazManagementSystem.Models;

namespace TurboazManagementSystem.ServiceOperations
{
 public  class RegistrationManager
    {
        public static void AddRegistration()
        {
            Registration registration = new Registration();
            Console.WriteLine("Giris novunu secin:");
            Console.WriteLine("1-Telefon nomresi ile giris, 2-Biznes hesabi ile giris");
            int secim = int.Parse(Console.ReadLine());
            if (secim==1)
            {
                Console.WriteLine("Telefon nomrenizi daxil edin: ");
                registration.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Telefon nomresine gelen kodu daxil edin: ");
                int code = int.Parse(Console.ReadLine());
            }
            else if (secim == 2)
            {
                Console.WriteLine("Email daxil edin: ");
                registration.Email = Console.ReadLine();
                Console.WriteLine("Password daxil edin: ");
                registration.Password = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Bele bir giris emeliyyati yoxdur!!");
            }
           
        }
    }
}
