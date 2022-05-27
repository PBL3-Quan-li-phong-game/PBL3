using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.Model.Context
{
    public class RECEIPT_ITEM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int ReceiptID { get; set; }
        public string ServiceID { get; set; }
        public int Amount { get; set; }

        [ForeignKey("ReceiptID")]
        public virtual RECEIPT RECEIPT { get; set; }
        [ForeignKey("ServiceID")]
        public virtual SERV Service { get; set; }
    }
}
