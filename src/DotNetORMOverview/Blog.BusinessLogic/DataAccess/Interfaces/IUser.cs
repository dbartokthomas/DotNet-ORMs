﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.BusinessLogic.DataAccess.Interfaces
{
    public interface IUser : IRepository<Model.User>
    {
        Model.User GetUserByUsername(string username);

        bool ValidateUser(string username, string password);
        bool UserExists(string username);
        bool EmailExists(string email);

        void AddNewUser(Model.User user);
    }
}
