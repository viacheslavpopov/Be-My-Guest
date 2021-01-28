using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace BeMyGuest.Models
{
    public class Evidence
    {
        // public Evidence()
        // {
        //     this.JoinEntries = new HashSet<Gathering>();
        // }
        public int EvidenceId { get; set; }
        // public int GuestId { get; set; }
        public string Question { get; set; }
        public string SexAnswer { get; set; }
        public int AgeAnswer { get; set; }
        public bool Fever { get; set; }
        public bool Cough { get; set; }
        public bool Sob { get; set; }
        public bool YesNo { get; set; }
        public string Explanation { get; set; }
        public int GuestCovidInfoId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Guest> Guests { get; set; }

        public static List<Evidence> GetEvidence()
        {
            var apiCallTask = EvidencesApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Evidence> covidList = JsonConvert.DeserializeObject<List<Evidence>>(jsonResponse.ToString());

            return covidList;
        }
        public static Evidence GetDetails(int id)
        {
            var apiCallTask = EvidencesApiHelper.Get(id);
            var result = apiCallTask.Result;
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Evidence Evidence = JsonConvert.DeserializeObject<Evidence>(jsonResponse.ToString());

            return Evidence;
        }
        public static void Post(Evidence evidence)
        {
            string jsonEvidence = JsonConvert.SerializeObject(evidence);
            var apiCallTask = EvidencesApiHelper.Post(jsonEvidence);
        }
        public static void Put(Evidence evidence)
        {
            string jsonEvidence = JsonConvert.SerializeObject(evidence);
            var apiCallTask = EvidencesApiHelper.Put(evidence.EvidenceId, jsonEvidence);
        }
        public static void Delete(int id)
        {
            var apiCallTask = EvidencesApiHelper.Delete(id);
        }
    }
}