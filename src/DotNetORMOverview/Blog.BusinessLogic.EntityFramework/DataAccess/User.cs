using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blog.BusinessLogic.DataAccess.Interfaces;

namespace Blog.BusinessLogic.EntityFramework.DataAccess
{
    public class User : IUser
    {
        public Model.User GetUserByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public Model.User GetByKey<TType>(TType t)
        {
            throw new NotImplementedException();
        }
    }
}
