using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tripManager.model
{
    public partial class Trip
    {


        public  Trip()
        {
            reservations = new HashSet<Reservation>();
            groups = new HashSet<Group>();
            tripGroups = new HashSet<TripGroup>();
        }
        public int ID { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public DateTime  Date{ get; set; }
        public string notes { get; set; }
        public Boolean hasChangablePrice { get; set; }
        public Boolean isFrozen { get; set; }
        public Boolean isDeleted { get; set; }



        public virtual ICollection<Reservation> reservations { get; set; }
        public virtual ICollection<Group> groups { get; set; }
        
        public virtual ICollection<TripGroup> tripGroups { get; set; }

      
    }
}
