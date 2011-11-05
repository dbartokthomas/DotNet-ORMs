using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.BusinessLogic.Model
{
    public class User
    {
        /// <summary>
        /// Username of the user
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Password of the user
        /// </summary>
        public string Password { get; set; }
        
        /// <summary>
        /// Email Address of the User
        /// </summary>
        public string EmailAddress { get; set; }
    }
}
