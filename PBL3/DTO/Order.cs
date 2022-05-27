using PBL3.Model.Context;
using System.Collections.Generic;

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