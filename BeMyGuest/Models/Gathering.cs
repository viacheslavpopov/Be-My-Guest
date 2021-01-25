using Microsoft.EntityFrameworkCore;

namespace BeMyGuest.Models
{
    public class Gathering
    {
        public int GatheringId { get; set; }
        public int? GuestId { get; set; }
        public int? HostId { get; set; }
        public int? EventId { get; set; }
        public Guest Guest { get; set; }
        public Host Host { get; set; }
        public Event Event { get; set; }

    }
}