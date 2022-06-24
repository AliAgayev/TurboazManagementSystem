using System;
using System.Collections.Generic;
using System.Text;
using TurboazManagementSystem.DAL;
using TurboazManagementSystem.Enums;
using TurboazManagementSystem.Models;

namespace TurboazManagementSystem.ServiceOperations
{
   public class ModelManager
    {
        public static void AddModel()
        {
            Model model = new Model();
            Console.WriteLine("Model adini daxil edin: ");
            model.Name = Console.ReadLine();
            Console.WriteLine("Modelin ban novunu daxil edin: ( Sedan = 1,Dartqi = 2,Furqon = 3,Hetcbek = 4,Karvan = 5," +
                "Kupe = 6,Motosiklet = 7,OffRoad = 8,Pickup = 9,Avtobus = 10,Universal = 11,Yukmasini = 12) ");
            model.BanType = (BanType)int.Parse(Console.ReadLine());
            Console.WriteLine("Modelin qiymetini daxil edin: ");
            model.Value =Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Modelin buraxilis ilini daxil edin: (il)");
            model.ReleaseDate =int.Parse(Console.ReadLine());
            Console.WriteLine("Modelin rengini daxil edin: ");
            model.Color = Console.ReadLine();
            Console.WriteLine("Modelin yanacaq novunu daxil edin: (benzin=1,dizel = 2,qaz = 3,elektro = 4,hibrid = 5)");
            model.FuelType = (FuelType)int.Parse(Console.ReadLine());
            Console.WriteLine("Modelin oturucusunu daxil edin: (arxa=1,on=2,tam=3)");
            model.Transmission = (TransmissionType)int.Parse(Console.ReadLine());
            Console.WriteLine("Modelin suretler qutusunu daxil edin: (mexaniki=1,avtomat=2,robotlasdirilmis=3,variator=4)");
            model.SpeedBox = (SpeedboxType)int.Parse(Console.ReadLine());
            Console.WriteLine("Modelin muherrik hecmini daxil edin: ");
            model.EngineCapacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Modelin at gucunu daxil edin: ");
            model.Power = int.Parse(Console.ReadLine());
            Console.WriteLine("Modelin yurusunu daxil edin: ");
            model.Milleage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Modelin elave funksiyanalliqlarini daxil edin");
            model.Desc = Console.ReadLine();

          
            Console.WriteLine("Marka adini daxil edin");
            string markaname = Console.ReadLine();

                foreach (var item in DataOperation.Markas)
                {
                    if (item.Name == markaname)
                    {
                        model.Markas.Add(item);
                        break;
                    }
                   else
                    {
                    Console.WriteLine("Bele bir marka yoxdur!!");
                    }
                }

            DataOperation.Models.Add(model);
        }

        public static void ShowModel()
        {
            foreach (var item in DataOperation.Models)
            {
                Console.WriteLine($"Model adi: {item.Name} , Modelin ban novu {item.BanType} , Modelin qiymeti {item.Value}" +
                    $" , Modelin rengi {item.Color} , Modelin at gucu {item.Power} , Modelin elave funksiyonalligi {item.Desc} , " +
                    $"Modelin yurusu {item.Milleage}, Modelin suretler qutusu {item.SpeedBox}");

                foreach (var marka in item.Markas)
                {
                    Console.WriteLine($"Marka adi: {marka.Name}");
                }
            }
        }

    }
}
