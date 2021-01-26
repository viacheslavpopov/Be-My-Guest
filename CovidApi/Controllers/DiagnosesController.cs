using CovidApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CovidApi.Controllers
{
    [Route("api/diagnoses")]
    [ApiController]
    public class DiagnosesController : ControllerBase
    {
        private CovidApiContext _db;
        public DiagnosesController(CovidApiContext db)
        {
            _db = db;
        }
        //GET api/diagnoses
        [HttpGet]
        public ActionResult<IEnumerable<Diagnosis>> Get()
        {
            var query = _db.Diagnoses.AsQueryable();
            return query.ToList();
        }
        //GET api/diagnoses/{1}
        [HttpGet("{id}")]
        public ActionResult<Diagnosis> GetById(int id)
        {
            return _db.Diagnoses
                .Include(diagnosis => diagnosis.Evidences)
                .FirstOrDefault(entry => entry.DiagnosisId == id);
        }
        //POST api/diagnoses
        [HttpPost]
        public void Post([FromBody] Diagnosis diagnosis)
        {
            _db.Diagnoses.Add(diagnosis);
            _db.SaveChanges();
        }
        //PUT api/diagnoses/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Diagnosis diagnosis)
        {
            diagnosis.DiagnosisId = id;
            _db.Entry(diagnosis).State = EntityState.Modified;
            _db.SaveChanges();
        }
        //DELETE api/diagnoses/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var diagnosisToDelete = _db.Diagnoses.FirstOrDefault(entry => entry.DiagnosisId == id);
            _db.Diagnoses.Remove(diagnosisToDelete);
            _db.SaveChanges();
        }
    }
}