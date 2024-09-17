using DataBaseLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface IUserService
    {
        void LogIn (string username, string password , out string message , out UserType userType);

    }
}
