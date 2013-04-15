using Angela.Core;
using SimpleSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleSite.Controllers
{
    public class HomeController : Controller
    {
        private static List<Person> _people = Angie.FastList<Person>();

        public ActionResult Index()
        {            
            return View(_people);
        }

    }
}
