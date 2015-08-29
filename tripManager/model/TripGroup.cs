using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tripManager.model
{
    public partial class TripGroup
    {
        public int ID { get; set; }
        public int tripID { get; set; }
        public int groupID { get; set; }

        public virtual Trip trip { get; set; }
        public virtual Group group { get; set; }
    }
    }

