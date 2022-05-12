﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model.obj
{
    public class CHAT_LOG
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
