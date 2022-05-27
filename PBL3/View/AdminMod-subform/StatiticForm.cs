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
using PBL3.BLL;


namespace PBL3.View.AdminMod_subform
{
    public partial class StatiticForm : Form
    {
        public StatiticForm()
        {
            InitializeComponent();
            SetupComponent();
        }

        private void SetupComponent()
        {
            cbbRange.Items.AddRange(new string[]
            {
                "Trong ngày", "Trong tuần", "Trong tháng", "Từ trước tới nay"
            });
            cbbRange.SelectedIndex = 0;

            StatiticView.Columns.AddRange(new ColumnHeader[]
            {
                new ColumnHeader { Text = "Tên hàng", Width = 162},
                new ColumnHeader { Text = "Số lượng", Width = 60}
            });
        }

        private void cbbRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatiticView.Items.Clear();
            List<StatiticItem> data = NetBLL.Instance.Statitic(cbbRange.SelectedIndex);
            foreach(StatiticItem item in data)
            {
                ListViewItem i = new ListViewItem(item.ServiceName);
                i.SubItems.Add(item.TotalCount.ToString());
                StatiticView.Items.Add(i);
            }
        }

        private void StatiticView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = StatiticView.Columns[e.ColumnIndex].Width;
        }
    }
}
