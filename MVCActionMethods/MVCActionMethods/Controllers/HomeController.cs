using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCActionMethods.Controllers
{
    public class HomeController : Controller
    {
    //this is an index method
        public ActionResult Index()
        {
            return View();
        }
        //returns viewresult
        public ViewResult VIndex()
        {
            ViewBag.ItemList = "Computer Shop Item List Page";
            return View();
        }
        //returns empty result
        public EmptyResult EIndex()
        {
            ViewBag.ItemList = "Hello Batch!";
            return new EmptyResult();
        }
        //redirects to another action method
        public RedirectResult AIndex()
        {
            return Redirect("Contact");
        }
        //redirects to another url
        public RedirectResult UIndex()
        {
            return Redirect("https://www.w3schools.com");
        }
        //RedirectToRouteResult is used whenever we need to go from one action to another.
        public RedirectToRouteResult RRIndex()
        {
            return RedirectToRoute(new { controller = "Test", action = "Index" });
        }
        //The RedirectToAction Result is returning the result to a specified controller and action method.
        public ActionResult RAIndex()
        {
            return RedirectToAction("Index", "Test");
        }
        //retuens JsonResult
        public JsonResult JIndex()
        {
            Employee emp = new Employee()
            {
                ID = "Emp1001",
                Name = "Jain",
                Mobile = "825415426"
            };
            return Json(emp, JsonRequestBehavior.AllowGet);
        }
        public string sIndex(string id)
        {
            return "ID =" + id;
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
    public class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
    }
}
