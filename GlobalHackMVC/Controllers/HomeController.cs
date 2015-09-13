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
            List<citation> model = new List<citation>();
            string fname = Request.Form["first_name"];
            string lname = Request.Form["last_name"];
            string dob = Request.Form["date_of_birth"];
            string dl = Request.Form["drivers_license_number"];
            var firstnames = db.citations.Where(x => x.first_name == fname).ToList();
            var lastnames = db.citations.Where(x => x.last_name == lname).ToList();
            //List<citation> dobs = new List<citation>();
            //if ()
            //    dobs = db.citations.Where(x => x.date_of_birth == Convert.ToDateTime(dob)).ToList();
            var dls = db.citations.Where(x => x.drivers_license_number == dl).ToList();
            
            if(string.IsNullOrEmpty(dob))
            {
                foreach(var item in dls)
                {
                    model = db.citations.Where(x => x.drivers_license_number == dl).ToList();
                }
            }
            

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