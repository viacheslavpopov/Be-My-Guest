using System.ComponentModel.DataAnnotations;
using System;

namespace BeMyGuest.Models
{
    public class Event
    {
        public Event()
        {
            this.Guests = new HashSet<Gathering>();
            this.Hosts = new HashSet<Gathering>();
        }
        public int EventId { get; set; }
        public DateTime EventDate { get; set; }
        public string Venue { get; set; }
        public string VenueAddress { get; set; }
        public string VenueRequirements { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string QuarantineRequirements { get; set; }
        public bool MaskRequirements { get; set; }
        public ICollection<Gathering> Guests { get; set; }
        public ICollection<Gathering> Hosts { get; set; }
    }
}