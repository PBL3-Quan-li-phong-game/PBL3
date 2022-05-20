using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.Model.Context;

namespace PBL3.DTO
{
    public class Order
    {
        public List<RECEIPT_ITEM> items { get; set; }
        public Order()
        {
            this.items = new List<RECEIPT_ITEM>();
        }
    }
}
