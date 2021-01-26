using BeMyGuest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BeMyGuestMVC.Controllers
{
    [Authorize(Roles = "Admin")]
    public class GuestsController: Controller
    {
        private readonly BeMyGuestContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public GuestsController(UserManager<ApplicationUser> userManager, BeMyGuestContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public ActionResult Index()
        {
            List<Guest> model = _db.Guests.ToList();
            return View(model);
        }

        public ActionResult Create() //--> stretch for creating their own event
        {
            ViewBag.GuestId = new SelectList(_db.Guests, "GuestId", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Guest guest, int GuestId)
        {
            _db.Guests.Add(guest);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id) //needs to connect to Host, GatheringJoin, CovidData
        {
            var thisGuest = _db.Guests
                // .Include(guest => guest.Hosts)
                // .ThenInclude(join => join.Host)
                .FirstOrDefault(guest => guest.GuestId == id);
            return View(thisGuest);
        }

        public ActionResult Edit(int id)
        {
            var thisGuest = _db.Guests.FirstOrDefault(guests => guests.GuestId == id);
            if (thisGuest == null)
            {
                return RedirectToAction("Details", new { id = id});
            }
            return View(thisGuest);
        }

        [HttpPost]
        public ActionResult Edit(Guest guest)
        {
            _db.Entry(guest).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Details", new { id = guest.GuestId });
        }

        public ActionResult Delete(int id)
        {
            var thisGuest = _db.Guests
                // .Include(guest => guest.Hosts)
                // .ThenInclude(join => join.Host)
                // // .Include(guest => guest.CovidData) // not sure how to properly set this up, or if it's needed
                .FirstOrDefault(guest => guest.GuestId == id);
            if (thisGuest == null)
            {
                return RedirectToAction("Details", new {id = id});
            }
            return View(thisGuest);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)//, int joinId)
        {
            // if (joinId != 0)
            // {
            //     var joinEntry = _db.Gathering.FirstOrDefault(entry => entry.GuestId == id);
            //     if(joinEntry != null)
            //     {
            //         _db.Gathering.Remove(joinEntry);
            //         var thisGuest = _db.Guests
            //             // .Include(guest => guest.Hosts)
            //             // .ThenInclude(join => join.Host)
            //             // .Include(guest => guest.CovidData) // not sure how to properly set this up or if needed
            //             .FirstOrDefault(guests => guests.GuestId == id);
            //         _db.Guests.Remove(thisGuest);
            //         _db.SaveChanges();
            //     }
            // }
            // else
            // {
                var thisGuest = _db.Guests
                    // .Include(guest => guest.Hosts)
                    // .ThenInclude(join => join.Host)
                    // .Include(guest => guest.CovidData)
                    .FirstOrDefault(guests => guests.GuestId == id);
                _db.Guests.Remove(thisGuest);
                _db.SaveChanges();
            // }
            return RedirectToAction("Index");
        }

        // [HttpPost]
        // public ActionResult DeleteHost(int joinId, int GuestId)
        // {
        //     var joinEntry = _db.Gathering.FirstOrDefault(entry => entry.GatheringId == joinId);
        //     _db.Gathering.Remove(joinEntry);
        //     _db.SaveChanges();
        //     return RedirectToAction("Details", new { id = guests.GuestId});
        // }
    }
}