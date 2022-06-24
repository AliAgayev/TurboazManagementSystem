using System;
using System.Collections.Generic;
using System.Text;

namespace TurboazManagementSystem.Models
{
  public  class Registration
    {
        public Registration()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
