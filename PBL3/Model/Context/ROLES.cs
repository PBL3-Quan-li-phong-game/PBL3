using System.Collections.Generic;

namespace PBL3.Model.Context
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
