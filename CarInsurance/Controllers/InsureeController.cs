using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);

                int preQuote = 50;

                int DOB = insuree.DateOfBirth.Year;
                int year = insuree.CarYear;
                string make = insuree.CarMake;
                string model = insuree.CarModel;
                int DobFee = 0;
                int yearFee = 0;
                int makeFee = 0;
                int modelFee = 0;

                if (DOB <= 18 && DOB < 19) { int Dobfee = 100; }
                else if (DOB >= 19 && DOB <= 25) { int Dobfee = 50; }
                else if (DOB > 25) { int Dobfee = 25; }

                if (year < 2000 || year > 2015) { int yearFee = 25; }


                if (make == "Porsche") { int makeFee = 25; }


                if (make == "Porsche" && model == "911 Carrera") { int modelFee = 25; }

                int preTotal = DobFee + yearFee + makeFee + modelFee;

                //If the car's Make is a Porsche, add $25 to the price.

                //If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        //public void insuranceDetermination(int insuree)
        //{
        //    int preQuote = 50;

        //    int DOB = insuree.DateOfBirth.Year;
        //    int year = insuree.CarYear;
        //    string make = insuree.CarMake;
        //    string model = insuree.CarModel;
        //    int DobFee = 0;
        //    int yearFee = 0;
        //    int makeFee = 0;
        //    int modelFee = 0;

        //    if (DOB <= 18 && DOB < 19) { int Dobfee = 100; }
        //    else if (DOB >= 19 && DOB <= 25) { int Dobfee = 50; }
        //    else if (DOB > 25) { int Dobfee = 25; }

        //    if (year < 2000 || year > 2015) { int yearFee = 25; }


        //    if (make == "Porsche") { int makeFee = 25; }


        //    if (make == "Porsche" && model == "911 Carrera") { int modelFee = 25; }

        //    int preTotal = DobFee + yearFee + makeFee + modelFee;
        //}

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
