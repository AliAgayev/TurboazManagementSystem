using System;
using TurboazManagementSystem.Models;
using TurboazManagementSystem.ServiceOperations;

namespace TurboazManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        public static void menu()
        {
            Console.WriteLine("1.Giris");
            Console.WriteLine("2.Marka elave et");
            Console.WriteLine("3.Markalari goster");
            Console.WriteLine("4.Model elave et");
            Console.WriteLine("5.Modelleri goster ");
            Console.WriteLine("6.Çıxış");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Manager<Registration>.serviceCall();
                    menu();
                    break;
                case 2:
                    Manager<Marka>.serviceCall();
                    menu();
                    break;
                case 3:
                    Manager<Marka>.serviceShow();
                    menu();
                    break;
                case 4:
                    Manager<Model>.serviceCall();
                    menu();
                    break;
                case 5:
                    Manager<Model>.serviceShow();
                    menu();
                    break;
                case 6:
                    return;
                default:
                    break;
            }
        }
    }
}
