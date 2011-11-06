using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.BusinessLogic.DataAccess.Interfaces;

namespace Blog.Controllers
{
    public class BaseController : Controller
    {
        IUnitOfWork _unitOfWork;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                if (_unitOfWork != null)
                    return _unitOfWork;

                _unitOfWork = new Blog.BusinessLogic.EntityFramework.DataAccess.UnitOfWork("BlogEntityFramework");
                return _unitOfWork;
            }
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);

            //Dispose of the UnitOfWork
            if (_unitOfWork != null)
                _unitOfWork.Dispose();
        }
    }
}