﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.Model.Context
{
    public class RECEIPT
    {
        public RECEIPT()
        {
            this.RECEIPT_ITEMs = new HashSet<RECEIPT_ITEM>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(18)]
        public string UserName { get; set; }
        public double TotalPrice { get; set; }
        public DateTime FormedDate { get; set; }

        [ForeignKey("UserName")]
        public virtual USERS USER { get; set; }

        public virtual ICollection<RECEIPT_ITEM> RECEIPT_ITEMs { get; set; }
    }
}
