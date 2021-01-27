using BeMyGuest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Collections.Generic;
using System.Linq;

namespace BeMyGuest.Controllers
{
    public class EventsController : Controller
    {
        private readonly BeMyGuestContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public EventsController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, BeMyGuestContext db)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
        }

        public async Task<ActionResult> Index()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            var userEvents = _db.Events.Where(entry => entry.User.Id == currentUser.Id).ToList();
            return View(userEvents);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Event myEvent)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            myEvent.User = currentUser;
            _db.Events.Add(myEvent);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var thisEvent = _db.Events.FirstOrDefault(myEvent => myEvent.EventId == id);
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ViewBag.IsCurrentUser = userId != null? userId == thisEvent.User.Id : false;
            return View(thisEvent);
        }

        public async Task<ActionResult> Edit(int id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            var thisEvent = _db.Events.Where(entry => entry.User.Id == currentUser.Id).FirstOrDefault(myEvent => myEvent.EventId == id);
            if(thisEvent == null)
            {
                return RedirectToAction("Details", new { id = id });
            }
            return View(thisEvent);
        }

        [HttpPost]
        public ActionResult Edit(Event myEvent)
        {
            _db.Entry(myEvent).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Details", new { id = myEvent.EventId});
        }

        // public async Task<ActionResult> AddGuest
         
    //   for ( var i =0; i<number; i++)
    //   {
    //     if (bookId != 0)
    //     {
    //       _db.Copies.Add(copy);
    //       _db.SaveChanges();
    //       copy.CopyId ++;
    //     }
    //   }
    //   return RedirectToAction("Index", "
    }
}