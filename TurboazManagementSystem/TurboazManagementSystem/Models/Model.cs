using System;
using System.Collections.Generic;
using System.Text;
using TurboazManagementSystem.Util;

namespace TurboazManagementSystem.Models
{
    public class Model:Car
    {
        public Model()
        {
            {
                Id = Guid.NewGuid().ToString();
                VIN = CustomVINCreated.GetCurrentTimeVIn();
                Markas = new List<Marka>();
            }
        }
        public Int64 VIN { get; set; }
        public string Desc { get; set; }
        public List<Marka> Markas { get; set; }
       
    }
}
