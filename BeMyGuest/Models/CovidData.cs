using System.Collections.Generic;

namespace BeMyGuest.Models
{
    public class CovidData
    {
        public CovidData()
        {
            this.JoinEntries = new HashSet<Gathering>();
        }
        public int CovidDataId { get; set; }
        public bool RecentTravel { get; set; }
        public bool Vaccine { get; set; }
        public bool Prescreening { get; set; }
        public bool HighRisk { get; set; }
        public string ExposureLevel { get; set; }
        public string Symptoms { get; set; }
        public virtaul ApplicationUser User { get; set; }
        public virtual ICollection<Gathering> JoinEntries  { get; set; }
    }
}