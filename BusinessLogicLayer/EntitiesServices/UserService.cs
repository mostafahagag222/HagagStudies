using BusinessLogicLayer.EntitiesDTOs;
using BusinessLogicLayer.Interfaces;
using DataBaseLayer.DB_Access;
using DataBaseLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.EntitiesServices
{
    public class UserService : IUserService
    {
        private readonly HotelContext context = new HotelContext();
        public void LogIn(string username, string password , out string message , out UserType userType)
        {
            try
            {
                userType = GetUserType(username, password);
                message = "User Found";
            }
            catch (Exception ex)
            {
                message = ex.Message;
                userType = UserType.NotUser;
            } 
        }

        public UserType GetUserType(string userName, string passWord )
        {
            var userr = context.Users.SingleOrDefault(u => u.UserName == userName);
            if (user == null)
            {
                throw new Exception("User Not Found");
            }
            if (passWord != user.Password)
            {
                throw new Exception("Invalid Password");
            }
            return user.UserType;
        }


    }
}
