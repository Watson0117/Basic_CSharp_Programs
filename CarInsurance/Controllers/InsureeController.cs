using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
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

                int baseFee = 50;//Start with a base of $50 / month.

                int DOB = insuree.DateOfBirth.Year; int year = insuree.CarYear; string make = insuree.CarMake;
                string model = insuree.CarModel; bool fullCoverage = insuree.CoverageType; double duiFee = 0;
                int DobFee = 0; int yearFee = 0; int makeFee = 0; int modelFee = 0; bool dui = insuree.DUI;
                double fullCoverageFee = 0; int speedTickets = insuree.SpeedingTickets;

                if (DOB <= 18 && DOB < 19) { DobFee = 100; }//If the user is 18 and under, add $100 to the monthly total.
                else if (DOB >= 19 && DOB <= 25) { DobFee = 50; }//If the user is between 19 and 25, add $50 to the monthly total.
                else if (DOB > 25) { DobFee = 25; } //If the user is over 25, add $25 to the monthly total.
                if (year < 2000 || year > 2015) { yearFee = 25; }//If the car's year is before 2000 or after 2015, add $25 to the monthly total.
                if (make == "Porsche") { makeFee = 25; }//If the car's Make is a Porsche, add $25 to the price.
                if (make == "Porsche" && model == "911 Carrera") { modelFee = 25; }//If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
                int speedFee = speedTickets * 10;//Add $10 to the monthly total for every speeding ticket the user has.

                double preTotal = baseFee + DobFee + yearFee + makeFee + modelFee + speedFee;

                if (dui == true) { duiFee = preTotal * .25; }//If the user has ever had a DUI, add 25 % to the total.
                if (fullCoverage == true) { fullCoverageFee = preTotal * .5; }//If it's full coverage, add 50% to the total.

                decimal duiFeeDec = Convert.ToDecimal(duiFee);
                decimal preTotalDec = Convert.ToDecimal(preTotal);
                decimal fullCoverageFeeDec = Convert.ToDecimal(fullCoverageFee);
                decimal Quote = baseFee + duiFeeDec + fullCoverageFeeDec + preTotalDec;

                insuree.Quote = Quote;

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        

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
                int baseFee = 50;//Start with a base of $50 / month.

                int DOB = insuree.DateOfBirth.Year; int year = insuree.CarYear; string make = insuree.CarMake;
                string model = insuree.CarModel; bool fullCoverage = insuree.CoverageType; double duiFee = 0;
                int DobFee = 0; int yearFee = 0; int makeFee = 0; int modelFee = 0; bool dui = insuree.DUI;
                double fullCoverageFee = 0; int speedTickets = insuree.SpeedingTickets;

                if (DOB <= 18 && DOB < 19) { DobFee = 100; }//If the user is 18 and under, add $100 to the monthly total.
                else if (DOB >= 19 && DOB <= 25) { DobFee = 50; }//If the user is between 19 and 25, add $50 to the monthly total.
                else if (DOB > 25) { DobFee = 25; } //If the user is over 25, add $25 to the monthly total.
                if (year < 2000 || year > 2015) { yearFee = 25; }//If the car's year is before 2000 or after 2015, add $25 to the monthly total.
                if (make == "Porsche") { makeFee = 25; }//If the car's Make is a Porsche, add $25 to the price.
                if (make == "Porsche" && model == "911 Carrera") { modelFee = 25; }//If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
                int speedFee = speedTickets * 10;//Add $10 to the monthly total for every speeding ticket the user has.

                double preTotal = baseFee + DobFee + yearFee + makeFee + modelFee + speedFee;

                if (dui == true) { duiFee = preTotal * .25; }//If the user has ever had a DUI, add 25 % to the total.
                if (fullCoverage == true) { fullCoverageFee = preTotal * .5; }//If it's full coverage, add 50% to the total.

                decimal duiFeeDec = Convert.ToDecimal(duiFee);
                decimal preTotalDec = Convert.ToDecimal(preTotal);
                decimal fullCoverageFeeDec = Convert.ToDecimal(fullCoverageFee);
                decimal Quote = baseFee + duiFeeDec + fullCoverageFeeDec + preTotalDec;

                insuree.Quote = Quote;
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
