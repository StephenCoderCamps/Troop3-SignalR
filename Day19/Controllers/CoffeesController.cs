using Day19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day19.Controllers
{
    public class CoffeesController : Controller
    {
        // GET: Coffees
        public ActionResult Index()
        {
            return View();
        }

        // GET: Coffees/Details/5
        public ActionResult Details()
        {
            var coffees = new List<Coffee> {
                new Coffee {Id=1, Type="Mocha"},
                new Coffee {Id=2, Type="Latte"},
                new Coffee {Id=3, Type="Breve"},
                new Coffee {Id=4, Type="Drip"}
            }; 

            return View(coffees);
        }

        // GET: Coffees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Coffees/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Coffees/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Coffees/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Coffees/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Coffees/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
