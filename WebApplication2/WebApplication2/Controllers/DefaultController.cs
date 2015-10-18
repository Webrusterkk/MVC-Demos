using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hello()
        {
            int a = 10, b = 20;
            int c = a + b;
            return Content(Convert.ToString(c));
        }

       
        public ActionResult Add()
        {
            int a = 10, b = 20;
            int c = a + b;
            ViewBag.a = 10;
            ViewBag.b = 20;
            ViewBag.c = c;
            return View(ViewBag);
            
        }

        public ActionResult hello1()
        {
            int a = 10, b = 20;
            int c = a + b;
           
            string con = "<table class=\"table-bordered\"><tr><td>First Number :</td><td>" + a.ToString() + "</td></tr><tr><td>Second Number :</td><td>" + b.ToString() + "</td></tr><tr><td>Result :</td><td>" + c.ToString() + "</td></tr></table>";
            return Content(con);
           
        }
    }
}