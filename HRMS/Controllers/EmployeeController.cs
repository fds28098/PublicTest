﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace HRMS.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [Authorize(Roles = "employee")]
        public ActionResult Index()
        {
            var ID = User.Identity.GetUserId();
            var Name = HttpContext.GetOwinContext().GetUserManager<AppUserManager>().FindById(ID).Name;
            ViewBag.Name = Name;
            return View();
        }
    }
}