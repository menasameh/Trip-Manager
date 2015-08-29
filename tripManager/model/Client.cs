using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tripManager.model
{
    public partial class Client
    {
        public Client()
        {
            clientGroups = new HashSet<ClientGroup>();
        }
        public int ID { get; set; }
        public string name { get; set; }
        public float phoneNumber { get; set; }

        public virtual ICollection<ClientGroup> clientGroups { get; set; }

    }
}
