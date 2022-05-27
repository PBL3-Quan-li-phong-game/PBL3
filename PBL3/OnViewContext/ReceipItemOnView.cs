using PBL3.Model.Context;
using PBL3.BLL;

namespace PBL3.OnViewContext
{
    public class ReceipItemOnView
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        
        public ReceipItemOnView(RECEIPT_ITEM i)
        {
            this.Name = NetBLL.Instance.getServicebyID(i.ServiceID).Name;
            this.Amount = i.Amount;
        }
    }
}
