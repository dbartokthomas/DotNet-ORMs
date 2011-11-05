using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blog.BusinessLogic.DataAccess.Interfaces;

namespace Blog.BusinessLogic.EntityFramework.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// Backing store for the User Repository
        /// </summary>
        private IUser _userRepository { get; set; }
        
        /// <summary>
        /// Getter for the User Repository backing variable
        /// </summary>
        public IUser UserRepository
        {
            get
            {
                if (_userRepository != null)
                    return _userRepository;

                //Create the repo for this class
                _userRepository = new User();

                //Return it
                return _userRepository;
            }
        }

        /// <summary>
        /// Create the UnitOfWork
        /// </summary>
        public UnitOfWork(string connString)
        { 
            
        }

        /// <summary>
        /// Save any changes down to the database
        /// </summary>
        /// <returns></returns>
        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
