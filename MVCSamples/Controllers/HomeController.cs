using MVCSamples.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSamples.Controllers
{
    public class HomeController : Controller
    {
        private static readonly Database _database = new Database();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DataLoadedFromView()
        {
            // Grab all people from 'database'
            // this is then serialized in the view
            // and placed in the resulting markup
            var model = _database.People;

            return View(model);
        }

        public ActionResult DataLoadedFromApi()
        {
            // Just return the view, data is then 
            // from the API via angularjs after page
            // has been rendered
            return View();
        }
    }
}