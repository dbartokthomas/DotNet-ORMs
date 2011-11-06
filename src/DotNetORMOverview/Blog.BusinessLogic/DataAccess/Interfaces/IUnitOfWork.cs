using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.BusinessLogic.DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Repository for the User class
        /// </summary>
        IUser UserRepository { get; }
        
        /// <summary>
        /// Write the changes to the Database
        /// </summary>
        /// <returns></returns>
        bool SaveChanges();
    }
}
