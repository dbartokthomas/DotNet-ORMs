using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace Blog.BusinessLogic.EntityFramework.DataAccess.Mapping
{
    public class User : EntityTypeConfiguration<Model.User>
    {
        public User()
        {
            base.HasKey(a => a.Username).Property(a => a.Username).HasMaxLength(100);
            Property(a => a.EmailAddress).HasMaxLength(100);
            Property(a => a.Password).HasMaxLength(32);
        }
    }
}
