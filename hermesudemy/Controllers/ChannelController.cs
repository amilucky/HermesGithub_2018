using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hermesudemy.Models;
using hermesudemy.ViewModels;

namespace hermesudemy.Controllers
{
    public class ChannelController : Controller
    {
        // GET: Channel
        public ActionResult Index()
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
        }
    }
}