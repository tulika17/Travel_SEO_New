using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SEO_Content.Models;

namespace SEO_Content.Controllers
{
    public class stateController : Controller
    {
        //
        // GET: /state/
        Travel_SEOContentEntities entities = new Travel_SEOContentEntities(); 
        public ActionResult Index()
        {
                      
            IList<state> lststate= entities.states.ToList();        

            return View(lststate);
        }

        //
        
        public ActionResult GetCityNames(int id)
        {
           List<City> lstcity= entities.Cities.Where(s =>s.state_id==id).ToList();
           return View(lstcity);
        }
        public ActionResult travelGuideByDestination(string city)
        {
            City lstcity = entities.Cities.First(s => s.city_name.Trim() == city.Trim());
            return View(lstcity);
           
        }
        // GET: /state/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /state/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /state/Create

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

        //
        // GET: /state/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /state/Edit/5

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

        //
        // GET: /state/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /state/Delete/5

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
