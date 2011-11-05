using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blog.BusinessLogic.DataAccess.Interfaces;

namespace Blog.BusinessLogic.EntityFramework.DataAccess
{
    public class User : IUser
    {
        /// <summary>
        /// Backing store for the Context, so we can query the DB
        /// </summary>
        BlogContext _context;

        public User(BlogContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context cannot be null");

            _context = context;
        }

        public Model.User GetUserByUsername(string username)
        {
            return (from user in _context.Set<Model.User>()
                    where user.Username.ToLower() == username.ToLower()
                    select user).SingleOrDefault();
        }

        public Model.User GetByKey<TType>(TType t)
        {
            throw new NotImplementedException();
        }
    }
}
