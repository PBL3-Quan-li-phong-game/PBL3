using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model.obj
{
    public class SERV
    {
        public SERV()
        {
            this.RECEIPT_ITEMs = new HashSet<RECEIPT_ITEM>();
        }

        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double UnitPrice { get; set; }

        public virtual ICollection<RECEIPT_ITEM> RECEIPT_ITEMs { get; set; }
    }
}
