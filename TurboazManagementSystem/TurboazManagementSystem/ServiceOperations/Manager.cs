using System;
using System.Collections.Generic;
using System.Text;
using TurboazManagementSystem.Models;

namespace TurboazManagementSystem.ServiceOperations
{
   public class Manager<T>

    {
        public static void serviceCall()
        {

            Type model = typeof(Model);
            if (typeof(T) == model)
            {
                ModelManager.AddModel();
            }

            Type marka = typeof(Marka);
            if (typeof(T) == marka)
            {
                MarkaManager.AddMarka();
            }
            Type registration = typeof(Registration);
            if (typeof(T) == registration)
            {
                RegistrationManager.AddRegistration();
            }
        }

        public static void serviceShow()
        {

            Type model = typeof(Model);
            if (typeof(T) == model)
            {
                ModelManager.ShowModel();
            }

            Type marka = typeof(Marka);
            if (typeof(T) == marka)
            {
                MarkaManager.ShowMarka();
            }
        }


    }
}
