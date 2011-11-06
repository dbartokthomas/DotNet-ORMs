using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Blog.BusinessLogic.EntityFramework.DataAccess
{
    public class BlogContext : DbContext
    {
        public BlogContext(string connectionString)
            : base(connectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DataAccess.Mapping.User());

            base.OnModelCreating(modelBuilder);
        }
    }
}
