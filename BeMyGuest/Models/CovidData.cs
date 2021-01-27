using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace BeMyGuest.Models
{
    public class CovidData
    {
        // public CovidData()
        // {
        //     this.JoinEntries = new HashSet<Gathering>();
        // }
        public int CovidDataId { get; set; }
        // public int GuestId { get; set; }
        public string Question { get; set; }
        // public string SexAnswer { get; set; }
        // public int AgeAnswer { get; set; }
        // public bool Fever { get; set; }
        // public bool Cough { get; set; }
        // public bool Sob { get; set; }
        // public bool YesNo { get; set; }
        // public string Explanation { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Guest> Guests { get; set; }

        public static List<CovidData> GetCovidData()
        {
            var apiCallTask = EvidencesApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<CovidData> covidList = JsonConvert.DeserializeObject<List<CovidData>>(jsonResponse.ToString());

            return covidList;
        }
        public static CovidData GetDetails(int id)
        {
            var apiCallTask = EvidencesApiHelper.Get(id);
            var result = apiCallTask.Result;
            Console.WriteLine("RESULT IN CONTROLLER: {0}", result);
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            Console.WriteLine("RESULT IN CONTROLLER: {0}", jsonResponse.ToString());
            CovidData CovidData = JsonConvert.DeserializeObject<CovidData>(jsonResponse.ToString());

            return CovidData;
        }
        public static void Post(CovidData covidData)
        {
            string jsonCovidData = JsonConvert.SerializeObject(covidData);
            var apiCallTask = EvidencesApiHelper.Post(jsonCovidData);
        }
        public static void Put(CovidData covidData)
        {
            string jsonCovidData = JsonConvert.SerializeObject(covidData);
            var apiCallTask = EvidencesApiHelper.Put(covidData.CovidDataId, jsonCovidData);
        }
        public static void Delete(int id)
        {
            var apiCallTask = EvidencesApiHelper.Delete(id);
        }
    }
}