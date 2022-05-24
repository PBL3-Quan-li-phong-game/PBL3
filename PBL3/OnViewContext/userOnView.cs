using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model.Context;

namespace PBL3.OnViewContext
{
    public class userOnView
    {
        public string UserName { get; set; }
        public int RoleID { get; set; }
        public string UsingPC { get; set; }
        public double RemainingMoney { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime LastLogin { get; set; }
        public bool OnlineStatus { get; set; }
        
        public userOnView(USERS user) 
        {
            this.UserName = user.UserName;
            this.RoleID = user.RoleID;
            this.UsingPC = user.UsingPC;
            this.RemainingMoney = Math.Round(user.RemainingMoney, 2);
            this.RegisterDate = user.RegisterDate;
            this.LastLogin = user.LastLogin;
            this.OnlineStatus = user.OnlineStatus;
        }
    }
}
