using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model.obj
{
    public class USERS
    {
        public USERS()
        {
            this.LOGIN_HISTORY = new HashSet<LOGIN_HISTORY>();
            this.RECEIPTs = new HashSet<RECEIPT>();
            this.SenderLog = new HashSet<CHAT_LOG>();
            this.ReceiverLog = new HashSet<CHAT_LOG>();
        }

        [Key][MaxLength(18)]
        public string UserName { get; set; }
        [MaxLength(18)][Required]
        public string PWD { get; set; }
        [Required]
        public int RoleID { get; set; }
        [MaxLength(6)]
        public string UsingPC { get; set; }
        public double RemainingMoney { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LastLogin { get; set; }
        public bool OnlineStatus { get; set; }

        [ForeignKey("RoleID")]
        public ROLES ROLE { get; set; }
        [ForeignKey("UsingPC")]
        public PC PC { get; set; }

        public virtual ICollection<LOGIN_HISTORY> LOGIN_HISTORY { get; set; }
        public virtual ICollection<RECEIPT> RECEIPTs { get; set; }
        public virtual ICollection<CHAT_LOG> SenderLog { get; set; }
        public virtual ICollection<CHAT_LOG> ReceiverLog { get; set; }
    }
}
