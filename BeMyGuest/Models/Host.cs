using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeMyGuest.Models
{
    public class Host
    {
        public Host()
        {
            this.JoinEntries = new HashSet<Gathering>();
        }
        public int HostId { get; set; }
        [Display(Name = "Host Name")]
        public string HostName { get; set; }
        [Display(Name = "Host Email")]
        public string HostEmail { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Gathering> JoinEntries { get; set; }
    }
}