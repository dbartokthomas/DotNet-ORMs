using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blog.BusinessLogic.EntityFramework.DataAccess;

namespace Blog.BusinessLogic.EntityFramework.Providers
{
    public class BlogMembership : Blog.BusinessLogic.Providers.BlogMembership
    {
        public BlogMembership()
            : base(new UnitOfWork("BlogEntityFramework"))
        {
            //This should work, no?
        }
    }
}
