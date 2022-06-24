using System;
using System.Collections.Generic;
using System.Text;
using TurboazManagementSystem.DAL;
using TurboazManagementSystem.Models;

namespace TurboazManagementSystem.ServiceOperations
{
   public  class MarkaManager
    {
        public static void AddMarka()
        {
            Marka marka = new Marka();
            Console.WriteLine("Marka adini daxil edin: ");
            marka.Name = Console.ReadLine();
            Console.WriteLine("Marka haqqinda elave melumat daxil edin: ");
            marka.Desc = Console.ReadLine();

            DataOperation.Markas.Add(marka);
        }

        public static int ShowMarka()
        {
            foreach (var item in DataOperation.Markas)
            {
                Console.WriteLine($"Marka adi: {item.Name} , Elave melumat {item.Desc}");
            }
            return DataOperation.Markas.Count;
        }
    }
}
