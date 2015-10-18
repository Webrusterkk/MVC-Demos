using PartialViewDemo.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PartialViewDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        /// <summary>
        /// Index action 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var model = new Company();

            model.Department = GetDepartmentList(5);
            return View(model);
        }

        /// <summary>
        /// Get Department list
        /// </summary>
        /// <param name="counter">counter</param>
        /// <returns></returns>
        public List<Department> GetDepartmentList(int counter)
        {
            var model = new List<Department>();
            for (var i = 1; i <= counter; i++)
            {
                var data = new Department();
                data.DepartmentName = "IT " + i;
                data.DepartmentRule = "Rule " + i;
                data.AdminComment = "Admin omment " + i;
                model.Add(data);
            }
            return model;
        }

        public PartialViewResult ShowPartailView()
        {
           
            return PartialView("_MySecondPartialView");
        }
    }
}
