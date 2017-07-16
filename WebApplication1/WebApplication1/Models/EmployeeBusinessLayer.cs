using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public UserStatus GetUserValidity(UserDetails u)

        {

            if (u.UserName == "Admin" && u.Password == "123")

            {

                return UserStatus.AuthenticatedAdmin;

            }

            else if (u.UserName == "User" && u.Password == "123")

            {

                return UserStatus.AuthentucatedUser;

            }

            else

            {

                return UserStatus.NonAuthenticatedUser;

            }

        }

    }
}