using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class RenderAcController : Controller
    {
        // GET: RenderAc
        public ActionResult Index(string a, string b)
        {
            int a1 = Convert.ToInt32(a);
            int b1 = Convert.ToInt32(b);
            int c = a1 + b1;
            ViewBag.a1 = a1;
            ViewBag.b1 = b1;
            ViewBag.c = c;
            return View(ViewBag);
        }
    }
}