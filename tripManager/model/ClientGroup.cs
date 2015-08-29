using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tripManager.model
{
    public partial class ClientGroup
    {
        public int ID { get; set; }
        public int clientID { get; set; }
        public int groupID { get; set; }

        public virtual Client client { get; set; }
        public virtual Group group { get; set; }
    }
}
