using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model.Context
{
    public class AREA
    {
        public AREA()
        {
            this.PCs = new HashSet<PC>();
        }

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }

        public virtual ICollection<PC> PCs { get; set; }
    }
}
