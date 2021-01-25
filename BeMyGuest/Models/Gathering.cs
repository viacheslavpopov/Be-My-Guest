using Microsoft.EntityFrameworkCore;

namespace BeMyGuest.Models
{
    public class Gathering
    {
        public int GatheringId { get; set; }
        public int? GuestId { get; set; }
        public int? HostId { get; set; }
        public int? EventId { get; set; }
        public virtual Guest Guest { get; set; }
        public virtual Host Host { get; set; }
        public virtual Event Event { get; set; }

    }
}