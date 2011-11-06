﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.BusinessLogic.EntityFramework.DataAccess;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            using (UnitOfWork uow = new UnitOfWork("BlogEntityFramework"))
            {
                var u = uow.UserRepository.GetUserByUsername("dean.thomas");
                if (u == null)
                { 
                    
                }
            }
            
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
