using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeMyGuest.Models;

namespace BeMyGuest.Controllers
{
    public class CovidDatasetController : Controller
    {
        public IActionResult Index()
        {
            var covidList = CovidData.GetCovidData();
            return View(covidList);
        }
    }
}