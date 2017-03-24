using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoDealership.Models;

namespace AutoDealership.Controllers
{
    public class AutomobileController : Controller
    {
        // GET: Automobile
        public ActionResult Index() 
        {
            var automobiles = from a in GetAutomobileList()
                              orderby a.ID
                              select a;
            return View(automobiles);
        }

        // GET: Automobile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Automobile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Automobile/Create
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

        // GET: Automobile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Automobile/Edit/5
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

        // GET: Automobile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Automobile/Delete/5
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

        [NonAction]
        public List<Automobile> GetAutomobileList()
        {
            return new List<Automobile>
            {
                new Automobile
                {
                    ID = 1,
                    Make = "Mercedes Benz",
                    Model = "S550",
                    Year = DateTime.Parse(DateTime.Today.ToString()),
                    Color = "Blue",
                },

                new Automobile
                {
                    ID =2,
                    Make = "Lexus",
                    Model = "GS530",
                    Year = DateTime.Parse(DateTime.Today.ToString()),
                    Color = "White",
                },

                new Automobile
                {
                    ID =3,
                    Make = "BMW",
                    Model = "Li750",
                    Year = DateTime.Parse(DateTime.Today.ToString()),
                    Color = "Silver",
                },

                new Automobile
                {
                    ID= 4,
                    Make= "Chrysler",
                    Model= "Avenger",
                    Year= DateTime.Parse(DateTime.Today.ToString()),
                    Color = "Black",
                    
                },
            };
        }
    }

}
