using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Admin()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;
                var insureeVms = new List<Insuree>();
                foreach ( var insuree in insurees)
                {
                    var insureeVm = new Insuree();
                    insureeVm.FirstName = insuree.FirstName;
                    insureeVm.LastName = insuree.LastName;
                    insureeVm.EmailAddress = insuree.EmailAddress;
                    insureeVm.Quote = (decimal)insuree.Quote;
                    insureeVms.Add(insureeVm);
                }
                return View(insureeVms);    
            }


            //The model item passed into the dictionary is of type 
            //    'System.Collections.Generic.List`1[CarInsurance.ViewModels.InsureeVm]'
            //    , but this dictionary requires a model item of type 
            //    'System.Collections.Generic.IEnumerable`1[CarInsurance.Models.Insuree]'





        }

    }
}