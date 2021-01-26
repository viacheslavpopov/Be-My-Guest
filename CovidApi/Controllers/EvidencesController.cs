using CovidApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CovidApi.Controllers
{
    [Route("api/evidences")]
    [ApiController]
    public class EvidencesController : ControllerBase
    {
        private CovidApiContext _db;
        public EvidencesController(CovidApiContext db)
        {
            _db = db;
        }
        //GET api/evidences
        [HttpGet]
        public ActionResult<IEnumerable<Evidence>> Get()
        {
            var query = _db.Evidences.AsQueryable();
            return query.ToList();
        }
        //POST api/evidences
        [HttpPost]
        public void Post([FromBody] Evidence evidence)
        {
            _db.Evidences.Add(evidence);
            _db.SaveChanges();
        }
        //PUT api/evidences/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Evidence evidence)
        {
            evidence.EvidenceId = id;
            _db.Entry(evidence).State = EntityState.Modified;
            _db.SaveChanges();
        }
        //DELETE api/evidences/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var evidenceToDelete = _db.Evidences.FirstOrDefault(entry => entry.EvidenceId == id);
            _db.Evidences.Remove(evidenceToDelete);
            _db.SaveChanges();
        }
    }
}