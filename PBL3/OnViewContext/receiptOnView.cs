using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model.Context;

namespace PBL3.OnViewContext
{
    public class receiptOnView
    {
        public int ID { get; set; }
        public DateTime FormedDate { get; set; }

        public receiptOnView(RECEIPT r)
        {
            this.ID = r.ID;
            this.FormedDate = r.FormedDate;
        }
    }
}
