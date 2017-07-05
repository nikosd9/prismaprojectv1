using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BingMap2.Models;

namespace BingMap2.Controllers
{
    public class HomeController : Controller
        {
            private MyContext db = new MyContext();
            
            public ActionResult Index()
            {
            // GET: Ships
                var ships = db.Ships.ToList();
                return View(ships);
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

        public int GetParameters(int shipId, string paramName)
        { 
            return db.Parameters.Find(shipId, paramName).Id; 
        }
        public IQueryable GetValues(int paramId,DateTime start, DateTime end)
        {
            var values = from v in db.ParameterValues
                      where v.DateTime >= start && v.DateTime <= end
                      select v.ParameterValueNum;
            return values;
        }
    }

   
}