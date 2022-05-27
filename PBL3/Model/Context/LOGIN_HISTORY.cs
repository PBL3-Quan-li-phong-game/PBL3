﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.Model.Context
{
    public class LOGIN_HISTORY
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(18)]
        public string UserName { get; set; }
        [MaxLength(6)]
        public string PCID { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LogoutTime { get; set; }

        [ForeignKey("UserName")]
        public virtual USERS USER { get; set; }
        [ForeignKey("PCID")]
        public virtual PC PC { get; set; }
    }
}
