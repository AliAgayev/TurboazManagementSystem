using System;
using System.Collections.Generic;
using System.Text;
using TurboazManagementSystem.Models;

namespace TurboazManagementSystem.DAL
{
    public class DataOperation
    {
        public static List<Marka> Markas { get; set; }
        public static List<Model> Models { get; set; }
        public static List<Registration> Registrations { get; set; }

        static DataOperation()
        {
            Markas = new List<Marka>();
            Models = new List<Model>();
            Registrations = new List<Registration>();
        }




    }
}
