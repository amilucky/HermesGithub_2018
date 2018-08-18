using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hermesudemy.Models;

namespace hermesudemy.ViewModels
{
    public class RandomCountryViewModel
    {
        public List<Country> Country { get; set; }
        public List<Channel> Channel { get; set; }
    }
}