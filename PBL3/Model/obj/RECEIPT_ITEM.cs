using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model.obj
{
    public class RECEIPT_ITEM
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int ReceiptID { get; set; }
        public string ServiceID { get; set; }
        public int Amount { get; set; }

        [ForeignKey("ReceiptID")]
        public RECEIPT RECEIPT { get; set; }
        [ForeignKey("ServiceID")]
        public SERV Service { get; set; }
    }
}
