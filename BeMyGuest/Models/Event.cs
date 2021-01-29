using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace BeMyGuest.Models
{
    public class Event
    {
        public Event()
        {
            this.JoinEntries = new HashSet<Gathering>();
        }
        public int EventId { get; set; }
        public string EventTitle { get; set; }
        [Display(Name="Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-dd-yyyy")]
        public DateTime? EventDate { get; set; }
        public string Venue { get; set; }
        [Display(Name = "Venue Address")]
        public string VenueAddress { get; set; }
        [Display(Name = "Venue Requirements")]
        public string VenueRequirements { get; set; }
        [Display(Name = "Start Time")]
        // [DataType(DataType.Time)]
        // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{HH:MM tt PST")]
        public DateTime? StartTime { get; set; }
        [Display(Name = "End Time")]
        // [DataType(DataType.Time)]
        // [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{HH:MM tt PST")]
        public DateTime? EndTime { get; set; }
        [Display(Name = "Quarantine Requirements")]
        public string QuarantineRequirements { get; set; }
        [Display(Name = "Mask Requirements")]
        public bool MaskRequirements { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Gathering> JoinEntries  { get; set; }
    }
}