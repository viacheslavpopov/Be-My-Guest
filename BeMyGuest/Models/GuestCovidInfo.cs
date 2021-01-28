using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace BeMyGuest.Models
{
    public class GuestCovidInfo
    {
        public GuestCovidInfo()
        {
            this.CovidData = new HashSet<CovidData>();
        }
        public int GuestCovidInfoId { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public ICollection<CovidData> CovidData { get; set; }

        public static List<GuestCovidInfo> GetGuestCovidInfo()
        {
            var apiCallTask = DiagnosesApiHelper.GetAll();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
            List<GuestCovidInfo> infoList = JsonConvert.DeserializeObject<List<GuestCovidInfo>>(jsonResponse.ToString());

            return infoList;
        }
        // public static GuestCovidInfo GetDetails(int id)
        // {
        //     var apiCallTask = DiagnosesApiHelper.Get(id);
        //     var result = apiCallTask.Result;
        //     JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
        //     GuestCovidInfo GuestCovidInfo = JsonConvert.DeserializeObject<GuestCovidInfo>(jsonResponse.ToString());

        //     return GuestCovidInfo;
        // }
        public static void Post(GuestCovidInfo guestCovidInfo)
        {
            string jsonGuestCovidData = JsonConvert.SerializeObject(guestCovidInfo);
            var apiCallTask = DiagnosesApiHelper.Post(jsonGuestCovidData);
        }
        public static void Put(GuestCovidInfo guestCovidInfo)
        {
            string jsonGuestCovidData = JsonConvert.SerializeObject(guestCovidInfo);
            var apiCallTask = DiagnosesApiHelper.Put(guestCovidInfo.GuestCovidInfoId, jsonGuestCovidData);
        }
        public static void Delete(int id)
        {
            var apiCallTask = DiagnosesApiHelper.Delete(id);
        }
    }
}