using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model.Context
{
    public class PC_STATUS
    {
        public PC_STATUS()
        {
            this.PCs = new HashSet<PC>();
        }

        [Key]
        public int ID { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<PC> PCs{ get; set; }
    }
}
