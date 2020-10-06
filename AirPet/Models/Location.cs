using System.Collections.Generic;

namespace AirPet.Models
{
  public class Location
    {
        public Location()
        {
            this.Hosts = new HashSet<Host>();
        }

        public int LocationId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Host> Hosts { get; set; }
    }
}