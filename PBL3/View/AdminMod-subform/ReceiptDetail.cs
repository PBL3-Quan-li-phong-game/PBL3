using PBL3.BLL;
using PBL3.Model.Context;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace PBL3.View.AdminMod_subform
{
    public partial class ReceiptDetail : Form
    {
        private RECEIPT RECEIPT;
        private List<RECEIPT_ITEM> data = new List<RECEIPT_ITEM>();
        public ReceiptDetail(int ID)
        {
            RECEIPT = NetBLL.Instance.getReceiptbyID(ID);
            InitializeComponent();
            GUI();
            LoadReceiptView();
        }
        private void GUI()
        {
            lvReceiptDetail.Columns.Add(new ColumnHeader { Name = "ServiceName", Text = "Tên món", Width = 100 });
            lvReceiptDetail.Columns.Add(new ColumnHeader { Name = "Unit", Text = "Đơn vị", Width = 60 });
            lvReceiptDetail.Columns.Add(new ColumnHeader { Name = "Amount", Text = "Số lượng", Width = 60 });
            IDlabel.Text = RECEIPT.ID.ToString();
            lUserName.Text = RECEIPT.UserName;
            lTotalCost.Text = RECEIPT.TotalPrice.ToString() + " Đ";
            lFormedDate.Text = RECEIPT.FormedDate.ToString();
        }
        private void LoadReceiptView()
        {
            List<RECEIPT_ITEM> riList = NetBLL.Instance.getAllReceiptItembyReceiptID(RECEIPT.ID);
            foreach (RECEIPT_ITEM i in riList)
            {
                int index = ItemIndex(i);
                if (index == -1) data.Add(i);
                else data.ElementAt(index).Amount += i.Amount;
            }
            foreach (RECEIPT_ITEM ri in data)
            {
                ListViewItem i = new ListViewItem(NetBLL.Instance.getServicebyID(ri.ServiceID).Name);
                i.SubItems.Add(NetBLL.Instance.getServicebyID(ri.ServiceID).Unit);
                i.SubItems.Add(ri.Amount.ToString());
                lvReceiptDetail.Items.Add(i);
            }
        }
        private int ItemIndex(RECEIPT_ITEM r)
        {
            foreach (RECEIPT_ITEM i in data)
            {
                if (i.ServiceID == r.ServiceID) return data.IndexOf(i);
            }
            return -1;
        }
    }
}
