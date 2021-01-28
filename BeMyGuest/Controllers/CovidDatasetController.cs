using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Collections.Generic;
using System.Linq;
using BeMyGuest.Models;


namespace BeMyGuest.Controllers
{
    public class CovidDataSetController : Controller
    {
        public IActionResult Index()
        {
            var covidList = CovidData.GetCovidData();
            return View(covidList);
        }
        [HttpPost]
        public IActionResult Index(CovidData covid)
        {
            CovidData.Post(covid);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var covidData = CovidData.GetDetails(id);
            return View(covidData);
        }
        public IActionResult Edit(int id)
        {
            var covidData = CovidData.GetDetails(id);
            return View(covidData);
        }

        [HttpPost]
        public IActionResult Details(int id, CovidData covid)
        {
            covid.EvidenceId = id;
            CovidData.Put(covid);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            CovidData.Delete(id);
            return RedirectToAction("Index");
        }

    }
}