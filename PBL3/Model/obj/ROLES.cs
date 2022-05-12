using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model.obj
{
    public class ROLES
    {
        public ROLES()
        {
            this.USERs = new HashSet<USERS>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<USERS> USERs { get; set; }
    }
}
