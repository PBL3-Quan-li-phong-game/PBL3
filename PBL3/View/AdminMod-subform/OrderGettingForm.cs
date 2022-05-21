using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.Model.Context;
using PBL3.BLL;


namespace PBL3.View.AdminMod_subform
{
    public partial class OrderGettingForm : Form
    {
        public List<Order> OrderList { get; set; }
        public OrderGettingForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            OrderList = new List<Order>();
            InitializeComponent();
            lvOrder.Columns.Add(new ColumnHeader { Name = "ServiceName", Text = "Tên món", Width = 170 });
            lvOrder.Columns.Add(new ColumnHeader { Name = "Amount", Text = "Số lượng", Width = 70 });
            bDiscard.Enabled = false;
            bMarkasDone.Enabled = false;
        }

        public void reloadOrderList()
        {
            if(lvConnection.SelectedItems == null || lvConnection.SelectedItems.Count == 0)
            {
                lvOrder.Items.Clear();
                txtTotalPrice.Text = "0";
                lNotify.Visible = true;
                bDiscard.Enabled = false;
                bMarkasDone.Enabled = false;
                //foreach(Order o in OrderList)
                //{
                //    if(o.items.Count > 0)
                //    {
                //        lvConnection.Items[OrderList.IndexOf(o)].Selected = true;
                //        break;
                //    }
                //}
                return;
            }
            if (OrderList.ElementAt(lvConnection.SelectedIndices[0]).items.Count == 0)
            {
                lvOrder.Items.Clear();
                txtTotalPrice.Text = "0";
                lNotify.Visible = true;
                bDiscard.Enabled = false;
                bMarkasDone.Enabled = false;
            }
            else
            {
                lvOrder.Items.Clear();
                txtTotalPrice.Text = "0";
                lNotify.Visible = false;
                bDiscard.Enabled = true;
                bMarkasDone.Enabled = true;
                foreach (RECEIPT_ITEM rt in OrderList.ElementAt(lvConnection.SelectedIndices[0]).items)
                {
                    ListViewItem i = new ListViewItem(NetBLL.Instance.getServicebyID(rt.ServiceID).Name);
                    i.SubItems.Add(rt.Amount.ToString());
                    lvOrder.Items.Add(i);
                    txtTotalPrice.Text = (Convert.ToInt32(txtTotalPrice.Text) + NetBLL.Instance.getServicebyID(rt.ServiceID).UnitPrice * rt.Amount).ToString();
                }
            }
        }

        private void bDiscard_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Xác nhận hủy đơn này ?", "Xác nhận", MessageBoxButtons.YesNo);
            if(r == DialogResult.Yes)
            {
                OrderList.ElementAt(lvConnection.SelectedIndices[0]).items.Clear();
                reloadOrderList();
            }
        }

        private void bMarkasDone_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Đã hoàn thành đơn hàng ?", "Xác nhận", MessageBoxButtons.YesNo);
            if( r == DialogResult.Yes)
            {
                foreach(RECEIPT_ITEM ri in OrderList.ElementAt(lvConnection.SelectedIndices[0]).items)
                {
                    NetBLL.Instance.AddReceiptItem(ri);
                }
                OrderList.ElementAt(lvConnection.SelectedIndices[0]).items.Clear();
                reloadOrderList();
            }
        }

        private void lwConnection_SelectedIndexChanged(object sender, EventArgs e)
        {
            reloadOrderList();
        }

        private void OrderGettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
