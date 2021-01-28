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
    public class GuestCovidInfosController : Controller
    {
        public IActionResult Index()
        {
            var covidInfo = GuestCovidInfo.GetGuestCovidInfo();
            return View(covidInfo);
        }
        [HttpPost]
        public IActionResult Index(GuestCovidInfo guestInfo)
        {
            GuestCovidInfo.Post(guestInfo);
            return RedirectToAction("Index");
        }

        // public IActionResult Details(int id)
        // {
        //     var covidInfo = GuestCovidInfo.GetDetails(id);
        //     return View(covidInfo);
        // }
        // public IActionResult Edit(int id)
        // {
        //     var covidInfo = GuestCovidInfo.GetDetails(id);
        //     return View(covidInfo);
        // }

        // [HttpPost]
        // public IActionResult Details(int id, GuestCovidInfo guestInfo)
        // {
        //     guestInfo.GuestCovidInfoId = id;
        //     GuestCovidInfo.Put(guestInfo);
        //     return RedirectToAction("Details", id);
        // }
        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            GuestCovidInfo.Delete(id);
            return RedirectToAction("Index");
        }

    }
}