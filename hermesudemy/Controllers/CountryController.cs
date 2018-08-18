using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hermesudemy.Models;
using hermesudemy.ViewModels;

namespace hermesudemy.Controllers
{
    public class CountryController : Controller
    {
        
        // GET: Country
        public ActionResult Index()
        {
            //var Country = new Country() { name = "Germany" };

            var Country = new List<Country>
            {
                new Country { name = "Czechia" },
                new Country { name = "Slovakia"}
            };
            var Channel = new List<Channel>
            {
                new Channel { name = "Modern Trade" },
                new Channel { name = "Tradidtional Trade"}
            };

            var viewModel = new RandomCountryViewModel
            {
                Country = Country,
                Channel = Channel
            };
            return View(viewModel);
            //return View(Country);
            //return Content("test");
        }

        // GET: Country/Random
        public ActionResult Random()
        {
            var Country = new List<Country>
            {
                new Country { name = "Czechia" },
                new Country { name = "Slovakia"}
            };
            var Channel = new List<Channel>
            {
                new Channel { name = "Modern Trade" },
                new Channel { name = "Tradidtional Trade"}
            };

            var viewModel = new RandomCountryViewModel
            {
                Country = Country,
                Channel = Channel
            };
            return View(viewModel);
            //return Content("test");
        }



        public ActionResult ByCreatedDate (int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }
    }
}