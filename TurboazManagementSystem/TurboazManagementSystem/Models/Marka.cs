using System;
using System.Collections.Generic;
using System.Text;

namespace TurboazManagementSystem.Models
{
  public  class Marka:Car
    {
        public Marka()
        {
            Id = Guid.NewGuid().ToString();
        }      
        public string Desc { get; set; }
    }
}
