using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Recent Travel")]
        public bool RecentTravel { get; set; }
        public bool Vaccine { get; set; }
        public bool Prescreening { get; set; }
        [Display(Name = "High Risk")]
        public bool HighRisk { get; set; }
        [Display(Name = "Exposure Level")]
        public string ExposureLevel { get; set; }
        public string Symptoms { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Guest> Guests { get; set; }
    }
}