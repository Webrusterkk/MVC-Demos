using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COOKIEDEMO2.Models;

namespace COOKIEDEMO2.Controllers
{
    public class C1Controller : Controller
    {
        // GET: C1
        public ActionResult Index()
        {

            CookieStore.SetCookie("EMP", "STEVE JOBS", TimeSpan.FromSeconds(50));
            return View();
        }

        public ViewResult Show()
        {
            return View();
        }
    }
}