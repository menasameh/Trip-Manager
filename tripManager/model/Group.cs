using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tripManager.model
{
    public partial class Group
    {
        public Group()
        {
            clientGroups = new HashSet<ClientGroup>();
        }
        public int ID { get; set; }
        public string name { get; set; }
        public int capacity { get; set; }
        public bool isBus { get; set; }
        public bool hasSizeLimit { get; set; }
        public int tripID { get; set; }


        public virtual ICollection<ClientGroup> clientGroups { get; set; }
    }
}
