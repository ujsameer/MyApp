using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Models;

namespace MyApp.Controllers
{   
    public class LocationsController : Controller
    {
        private MyAppContext context = new MyAppContext();

        //
        // GET: /Locations/

        public ViewResult Index()
        {
            return View(context.Locations.ToList());
        }

        //
        // GET: /Locations/Details/5

        public ViewResult Details(int id)
        {
            Location location = context.Locations.Single(x => x.LocationId == id);
            return View(location);
        }

        //
        // GET: /Locations/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Locations/Create

        [HttpPost]
        public ActionResult Create(Location location)
        {
            if (ModelState.IsValid)
            {
                context.Locations.Add(location);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(location);
        }
        
        //
        // GET: /Locations/Edit/5
 
        public ActionResult Edit(int id)
        {
            Location location = context.Locations.Single(x => x.LocationId == id);
            return View(location);
        }

        //
        // POST: /Locations/Edit/5

        [HttpPost]
        public ActionResult Edit(Location location)
        {
            if (ModelState.IsValid)
            {
                context.Entry(location).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(location);
        }

        //
        // GET: /Locations/Delete/5
 
        public ActionResult Delete(int id)
        {
            Location location = context.Locations.Single(x => x.LocationId == id);
            return View(location);
        }

        //
        // POST: /Locations/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Location location = context.Locations.Single(x => x.LocationId == id);
            context.Locations.Remove(location);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}