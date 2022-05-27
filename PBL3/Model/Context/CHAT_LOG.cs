using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.Model.Context
{
    public class CHAT_LOG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(18)]
        public string sender { get; set; }
        [MaxLength(18)]
        public string receiver { get; set; }
        [MaxLength(100)]
        public string msg { get; set; }
        public DateTime SendTime { get; set; }

        [ForeignKey("sender")]
        public virtual USERS Sender { get; set; }
        [ForeignKey("receiver")]
        public virtual USERS Receiver { get; set; }
    }
}
