using DataBaseLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.EntitiesDTOs
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
    }
}
