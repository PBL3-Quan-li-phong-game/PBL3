using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model.Context;

namespace PBL3.OnViewContext
{
    public class pcOnView
    {
        public string ID { get; set; }
        public double RemainingMoney { get; set; }
        public string UsingUser { get; set; }
        public string pcStatus { get; set; }
        public pcOnView(PC pc)
        {
            this.ID = pc.ID;
            this.pcStatus = pc.PC_Status.StatusName;
            if(pc.USERS.Count == 0)
            {
                this.UsingUser = null;
                this.RemainingMoney = 0;
            }
            else
            {
                this.UsingUser = pc.USERS.ElementAt(0).UserName;
                this.RemainingMoney = pc.USERS.ElementAt(0).RemainingMoney;
            }
        }
    }
}
