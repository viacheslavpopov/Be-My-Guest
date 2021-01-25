using System.Collections.Generic;

namespace BeMyGuest.Models
{
    public class Host
    {
        public int HostId { get; set; }
        public string HostName { get; set; }
        public string HostEmail { get; set; }
        public virtual ICollection<Gathering> JoinEntries  { get; set; }
    }
    
}