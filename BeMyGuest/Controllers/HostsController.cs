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
    // [Authorize(Roles = "Admin")]
    [Authorize(Roles = "Host")]
    public class HostsController : Controller
    {
        private readonly BeMyGuestContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public HostsController(UserManager<ApplicationUser> userManager, BeMyGuestContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public ActionResult Index()
        {
            Dictionary<object, object> model = new Dictionary<object, object>();
            List<Guest> guests = _db.Guests.ToList();
            List<Event> events = _db.Events.ToList();
            model.Add("guests", guests);
            model.Add("events", events);
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Host host)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            host.User = currentUser;
            _db.Hosts.Add(host);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var thisHost = _db.Hosts.FirstOrDefault(host => host.HostId == id);
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            ViewBag.IsCurrentUser = userId != null ? userId == thisHost.User.Id : false;
            return View(thisHost);
        }

        public async Task<ActionResult> Edit(int id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            var thisHost = _db.Hosts
                .Where(entry => entry.User.Id == currentUser.Id)
                .FirstOrDefault(host => host.HostId == id);
            if (thisHost == null)
            {
                return RedirectToAction("Details", new { id = id });
            }
            return View(thisHost);
        }

        [HttpPost]
        public ActionResult Edit(Host host)
        {
            _db.Entry(host).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> AddGuest(int id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            Host thisHost = _db.Hosts
                .Where(entry => entry.User.Id == currentUser.Id)
                .FirstOrDefault(host => host.HostId == id);
            if (thisHost == null)
            {
                return RedirectToAction("Details", new { id = id });
            }
            ViewBag.GuestId = new SelectList(_db.Guests);
            return View(thisHost);
        }

        [HttpPost]
        public ActionResult AddGuest(Host host, int GuestId)
        {
            if (GuestId != 0)
            {
                var returnedJoined = _db.Gathering.Any(join => join.HostId == host.HostId && join.GuestId == GuestId);
                if (!returnedJoined)
                {
                    _db.Gathering.Add(new Gathering() { GuestId = GuestId, HostId = host.HostId });
                }
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> AddEvent(int id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            Host thisHost = _db.Hosts
                .Where(entry => entry.User.Id == currentUser.Id)
                .FirstOrDefault(host => host.HostId == id);
            if (thisHost == null)
            {
                return RedirectToAction("Details", new { id = id });
            }
            ViewBag.EventId = new SelectList(_db.Events);
            return View(thisHost);
        }

        [HttpPost]
        public ActionResult AddEvent(Host host, int EventId)
        {
            if (EventId != 0)
            {
                var returnedJoined = _db.Gathering.Any(join => join.HostId == host.HostId && join.EventId == EventId);
                if (!returnedJoined)
                {
                    _db.Gathering.Add(new Gathering() { EventId = EventId, HostId = host.HostId });
                }
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(int id)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            Host thisHost = _db.Hosts
                .Where(entry => entry.User.Id == currentUser.Id)
                .FirstOrDefault(host => host.HostId == id);
            if (thisHost == null)
            {
                return RedirectToAction("Details", new { id = id });
            }
            return View(thisHost);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisHost = _db.Hosts.FirstOrDefault(host => host.HostId == id);
            _db.Hosts.Remove(thisHost);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteGuest(int joinId)
        {
            var joinEntry = _db.Gathering.FirstOrDefault(entry => entry.GatheringId == joinId);
            _db.Gathering.Remove(joinEntry);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
