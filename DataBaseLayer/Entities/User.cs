using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLayer.Entities
{
    public enum UserType
    {
        NotUser,
        FrontEnd,
        Kitchen
    }
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
    }
}
