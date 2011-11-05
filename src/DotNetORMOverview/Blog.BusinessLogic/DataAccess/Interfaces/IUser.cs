using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.BusinessLogic.DataAccess.Interfaces
{
    public interface IUser
    {
        Model.User GetUserByUsername(string username);
    }
}
