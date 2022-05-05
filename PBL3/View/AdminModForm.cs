using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class AdminModForm : Form
    {
        public delegate void CloseGate();
        public CloseGate close;
        public AdminModForm()
        {
            InitializeComponent();
            this.timer.Enabled = true;
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]{
                new DataColumn { ColumnName = "Tên tài khoản", DataType = typeof(string) },
                new DataColumn { ColumnName = "Số tiền còn lại", DataType = typeof(int) },
                new DataColumn { ColumnName = "Thời gian còn lại", DataType = typeof(string) }
            });
            dt.Rows.Add("user1", 30000, "5:00:00");
            dgvAccount.DataSource = dt;
        }

        private void AdminModForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lDateTime.Text = DateTime.Now.ToString();
        }

        private void dgvAccount_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right && dgvAccount.SelectedRows.Count > 0)
            {
                cmsAccount.Show(dgvAccount, new Point(e.X + 50, e.Y + 40));
            }
        }
    }
}
