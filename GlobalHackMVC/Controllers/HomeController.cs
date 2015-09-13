using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace GlobalHackMVC.Controllers
{
    public class HomeController : Controller
    {
        private globalhackEntities1 db = new globalhackEntities1();
        public ActionResult Index()
        {
            return View();
        }
             
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            string fname = Request.Form["first_name"];
            string lname = Request.Form["last_name"];
            string dob = Request.Form["date_of_birth"];
            string dl = Request.Form["drivers_license_number"];
            var model = db.citations.Where(x => x.first_name == fname).ToList();

            return View("ListCitations", model);
        }
        public ActionResult ListCitations(List<citation> citations)
        {
            

            return View(citations);
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
}