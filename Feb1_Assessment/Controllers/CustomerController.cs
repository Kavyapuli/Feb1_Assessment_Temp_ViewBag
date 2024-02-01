using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Feb1_Assessment.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<string> list = new List<string>()
            {
                "kavya",
                "Sweety"
            };
            ViewBag.namelist = list;
            return View();
        }
        public ActionResult ReDirectDemo()
        {
            TempData["tempmsg"] = "Welcome to our page";
            return RedirectToAction("DisplayMessage");
        }
        public ActionResult DisplayMessage()
        {
            
            return View();
        }
    }
}