using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model.Context
{
    public class PC
    {
        public PC() 
        {
            this.USERS = new HashSet<USERS>();
        }

        [Key][MaxLength(6)]
        public string ID { get; set; }
        public int AreaID { get; set; }
        public int StatusID { get; set; }

        [ForeignKey("AreaID")]
        public virtual AREA AREA { get; set; }

        [ForeignKey("StatusID")]
        public virtual PC_STATUS PC_Status { get; set; }
        
        public virtual ICollection<USERS> USERS { get; set; }
    }
}
