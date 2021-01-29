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
    public class EvidencesController : Controller
    {
        public IActionResult Index()
        {
            var covidList = Evidence.GetEvidence();
            return View(covidList);
        }
        [HttpPost]
        public IActionResult Index(Evidence evidence)
        {
            Evidence.Post(evidence);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var evidence = Evidence.GetDetails(id);
            return View(evidence);
        }
        public IActionResult Edit(int id)
        {
            var evidence = Evidence.GetDetails(id);
            return View(evidence);
        }

        [HttpPost]
        public IActionResult Edit(Evidence evidence)
        {
            Evidence.Put(evidence);
            if (evidence.EvidenceId == 8)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Edit", new { id = evidence.EvidenceId + 1 });
            }
        }

        public IActionResult Delete(int id)
        {
            Evidence.Delete(id);
            return RedirectToAction("Index");
        }

    }
}