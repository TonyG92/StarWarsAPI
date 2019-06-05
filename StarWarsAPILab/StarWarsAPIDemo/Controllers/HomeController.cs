using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StarWarsAPIDemo.Models;

namespace StarWarsAPIDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PersonForm()
        {

            return View();
        }

        public ActionResult PlanetForm()
        {

            return View();
        }

        public ActionResult Person(int i)
        {
            Person person = StarWarsDAL.GetPerson(i);

            return View("PersonView", person);

        }
        public ActionResult Planet(int i)
        {
            Planet planet = StarWarsDAL.GetPlanet(i);

            return View("PlanetView", planet);
        }

        public ActionResult PersonView()
        {
            return View();
        }
        public ActionResult PlanetView()
        {
            return View();
        }
    }
}