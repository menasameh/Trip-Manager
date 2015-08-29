using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tripManager.model
{
    public partial class Reservation
    {
        public int ID { get; set; }
        public int tripID { get; set; }
        public int clientID { get; set; }

        public float priceToPay { get; set; }
        public float pricePaid { get; set; }
        public DateTime Date { get; set; }


        public virtual Client client { get; set; }
        public virtual Trip trip { get; set; }
    }
}
