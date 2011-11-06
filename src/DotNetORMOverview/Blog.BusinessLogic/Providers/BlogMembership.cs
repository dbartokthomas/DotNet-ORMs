using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;
using Blog.BusinessLogic.DataAccess.Interfaces;

namespace Blog.BusinessLogic.Providers
{
    public abstract class BlogMembership : MembershipProvider
    {
        IUnitOfWork _unitOfWork;
        
        protected BlogMembership(IUnitOfWork uow)
        {
            if (uow == null)
                throw new ArgumentNullException("UnitOfWork cannot be null!");

            _unitOfWork = uow;
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override bool ChangePassword(string username, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
        {
            throw new NotImplementedException();
        }

        //protected abstract IUser CreateUser(string username, string password, string email);
        public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            bool create = true;
            MembershipCreateStatus createStatus = MembershipCreateStatus.Success;

            //Make sure this user doesn't already exist
            if (_unitOfWork.UserRepository.UserExists(username))
            {
                createStatus = MembershipCreateStatus.DuplicateUserName;
                create = false;
            }

            if (_unitOfWork.UserRepository.EmailExists(email))
            {
                createStatus = MembershipCreateStatus.DuplicateEmail;
                create = false;
            }

            //Create the new User
            if (create)
            {
                Model.User newUser = new Model.User();
                newUser.EmailAddress = email;
                newUser.Username = username;
                newUser.Password = password;
                
                //Add the new user
                _unitOfWork.UserRepository.AddNewUser(newUser);

                //Save the changes
                if (_unitOfWork.SaveChanges())
                { 
                    //Return a nice MembershipUser
                    
                }
            }

            status = createStatus;
            return null;
        }

        public override bool DeleteUser(string username, bool deleteAllRelatedData)
        {
            throw new NotImplementedException();
        }

        public override bool EnablePasswordReset
        {
            get { throw new NotImplementedException(); }
        }

        public override bool EnablePasswordRetrieval
        {
            get { throw new NotImplementedException(); }
        }

        public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
        {
            throw new NotImplementedException();
        }

        public override int GetNumberOfUsersOnline()
        {
            throw new NotImplementedException();
        }

        public override string GetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }

        public override MembershipUser GetUser(string username, bool userIsOnline)
        {
            throw new NotImplementedException();
        }

        public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
        {
            throw new NotImplementedException();
        }

        public override string GetUserNameByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public override int MaxInvalidPasswordAttempts
        {
            get { throw new NotImplementedException(); }
        }

        public override int MinRequiredNonAlphanumericCharacters
        {
            get { throw new NotImplementedException(); }
        }

        public override int MinRequiredPasswordLength
        {
            get { return 6; }
        }

        public override int PasswordAttemptWindow
        {
            get { throw new NotImplementedException(); }
        }

        public override MembershipPasswordFormat PasswordFormat
        {
            get { throw new NotImplementedException(); }
        }

        public override string PasswordStrengthRegularExpression
        {
            get { throw new NotImplementedException(); }
        }

        public override bool RequiresQuestionAndAnswer
        {
            get { throw new NotImplementedException(); }
        }

        public override bool RequiresUniqueEmail
        {
            get { throw new NotImplementedException(); }
        }

        public override string ResetPassword(string username, string answer)
        {
            throw new NotImplementedException();
        }

        public override bool UnlockUser(string userName)
        {
            throw new NotImplementedException();
        }

        public override void UpdateUser(MembershipUser user)
        {
            throw new NotImplementedException();
        }

        public override bool ValidateUser(string username, string password)
        {
            return _unitOfWork.UserRepository.ValidateUser(username, password);
        }
    }
}
