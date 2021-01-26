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
        public async Task<ActionResult> Create(Event event)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            event.User = currentUser;
            _db.Events.Add(event);
            _db.SaveChanges();
            return RedirectToActionResult("Details", new { id = Event.EventId});
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var thisEvent = _db.Events.FirstOrDefault(event => event.EventId == id);
            var userId = thisEvent.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ViewBag.IsCurrentUser = userId != null? userId == thisEvent.User.Id : false;
            return ViewComponent(thisEvent);
        }

        public async Task<ActionResult> Edit(int id)
        {
            var userId this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            var thisEvent = _db.Events.Where(entry => entry.User.Id == currentUser.Id).FirstOrDefault(event => event.EventId == id);
            if(thisEvent == null)
            {
                return RedirectToAction("Details", new { id = id })
            }
            return View(thisEvent);
        }

        [HttpPost]
        public ActionResult Edit(Event event)
        {
            _db.Entry(event).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToActionResult("Details", new { id = event.EventId});
        }
    }
}